using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelpers;
using System.Data.SqlClient;
using NetExtend.Utils;
using DBTool.Forms;
using System.Threading;
using System.IO;
using NetExtend.Components;

namespace DBTool
{
    public partial class FmMain : Form
    {        
        public List<DBConnInfo> DBConnInfoList { get; private set; }
        public DBConnInfo CurrDBConnInfo { get; private set; }
        private DBHelper db; 
        public FmMain()
        {
            InitializeComponent();            
            InitDGVDBConnectInfo();
            InitDGVObject();
        }

        private void InitDGVObject()
        {
            DGVObject.AutoGenerateColumns = false;
            DGVObject.Columns[DGVObject.Columns.Add("Name", "物件名稱")].DataPropertyName = "Name";
            DGVObject.Columns[DGVObject.Columns.Add("Type", "物件類型代碼")].DataPropertyName = "Type";
            DGVObject.Columns[DGVObject.Columns.Add("TypeDesc", "物件類型")].DataPropertyName = "TypeDesc";
            DGVObject.Columns[DGVObject.Columns.Add("CrDate", "建立日期")].DataPropertyName = "CrDate";
            DGVObject.Columns[DGVObject.Columns.Add("Definition", "物件內容")].DataPropertyName = "Definition";
        }

        private void RefreshDGVDBConnectInfo()
        {
            DBConnInfoList = DBConnInfoRepo.GetInstance().Get();
            DGVDBConnectInfo.DataSource = DBConnInfoList;
            DGVDBConnectInfo.AutoResizeColumns();
        }

        private void InitDGVDBConnectInfo()
        {
            DGVDBConnectInfo.AutoGenerateColumns = false;            
            DGVDBConnectInfo.Columns[DGVDBConnectInfo.Columns.Add("DBTxt", "資料庫說明")].DataPropertyName = "DBTxt";
            DGVDBConnectInfo.Columns[DGVDBConnectInfo.Columns.Add("Server", "伺服器")].DataPropertyName = "Server";
            DGVDBConnectInfo.Columns[DGVDBConnectInfo.Columns.Add("DBName", "資料庫名")].DataPropertyName = "DBName";
            RefreshDGVDBConnectInfo();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TSMIAddDBConnInfo_Click(object sender, EventArgs e)
        {
            using (FmDBConnInfoUpsert fm = new FmDBConnInfoUpsert(null))
            {
                fm.ShowDialog(this);
            }
            RefreshDGVDBConnectInfo();
        }

        private void DGVDBConnectInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SwitchDB((DBConnInfo)DGVDBConnectInfo.CurrentRow.DataBoundItem);            
        }

        private void SwitchDB(DBConnInfo info)
        {
            CurrDBConnInfo = info;
            tSSLName.Text = $"Name : {CurrDBConnInfo.DBTxt}";
            tSSLServer.Text = $"Server : {CurrDBConnInfo.Server}";
            tSSLDBName.Text = $"DB : {CurrDBConnInfo.DBName}";
            db = new DBHelper(SqlClientFactory.Instance, CurrDBConnInfo.GetConnectionString());
            DGVObject.DataSource = null;
            DGVSqlResult.DataSource = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrDBConnInfo == null)
            {
                MessageBox.Show("請選擇資料庫");
                return;
            }

            var sql = @"
                select a.name, a.crdate, a.Type, b.definition 
                from sys.sysobjects a(nolock) 
                    left outer join sys.sql_modules b(nolock) on a.id=b.object_id 
                where 1=1";
            var prms = new List<object>();
            
            if (!string.IsNullOrEmpty(TxtKeyword.Text))
            {
                sql += " and a.name like {0}";
                prms.Add(TxtKeyword.Text + "%");
            }

            sql += " order by a.name";            
            var objList = db.ExecuteList<SqlObject>(sql, prms.ToArray());
                
            DGVObject.DataSource = objList;
            DGVObject.AutoResizeColumn(0);
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            var sqlObj = (SqlObject)DGVObject.CurrentRow.DataBoundItem;

            TsmiCompare.DropDownItems.Clear();
            TsmiSync.DropDownItems.Clear();
            foreach (var info in DBConnInfoList.Where(x=>x!=CurrDBConnInfo))
            {
                var miCompare = new ToolStripMenuItem(info.FullName);
                //比對
                miCompare.Click += (obj, args) =>
                {                    
                    var sourFile = SqlDefinition.ExportDefinitionToTempCompareFile(CurrDBConnInfo, sqlObj.Name);
                    var trgtFile = SqlDefinition.ExportDefinitionToTempCompareFile(info, sqlObj.Name);
                    var cmd = $@"{System.IO.Directory.GetCurrentDirectory()}\Tools\WinMergeU.exe ""{sourFile}"" ""{trgtFile}""";
                    CommandUtils.ExecuteCommandSync(cmd);
                };
                TsmiCompare.DropDownItems.Add(miCompare);

                var miSync = new ToolStripMenuItem(info.FullName);
                miSync.Click += (obj, args) =>
                {
                    if (MessageBox.Show($"是否確定同步物件[{sqlObj.Name}]從{CurrDBConnInfo.FullName}-->{info.FullName}", "物件同步", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                    var rslt = SqlDefinition.SyncObj(CurrDBConnInfo, info, sqlObj.Name);
                    MessageBox.Show(rslt != string.Empty ? rslt : "同步成功");   
                };
                TsmiSync.DropDownItems.Add(miSync);
            }            
        }

        private void 檢視內容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = (SqlObject)DGVObject.CurrentRow.DataBoundItem;
            using (FmObjDefinition fm = new FmObjDefinition(obj.Name, obj.Definition))
            {
                fm.ShowDialog(this);
            };
        }

        private void TsmiSync_Click(object sender, EventArgs e)
        {

        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConnInfoRepo.GetInstance().Delete((DBConnInfo)DGVDBConnectInfo.CurrentRow.DataBoundItem);
            RefreshDGVDBConnectInfo();

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FmDBConnInfoUpsert fm = new FmDBConnInfoUpsert((DBConnInfo)DGVDBConnectInfo.CurrentRow.DataBoundItem))
            {
                fm.ShowDialog(this);
            }
            RefreshDGVDBConnectInfo();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (CurrDBConnInfo == null)
            {
                MessageBox.Show("請選擇資料庫");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtxtSQL.Text))
            {
                MessageBox.Show("語法空白");
                return;
            }

            try
            {
                var dt = db.ExecuteDataTable(rtxtSQL.Text);
                DGVSqlResult.DataSource = dt;
            }
            catch (Exception ex)
            {
                DGVSqlResult.DataSource = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void 同步多處ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FmSyncMulti fm = new FmSyncMulti(CurrDBConnInfo, ((SqlObject)DGVObject.CurrentRow.DataBoundItem).Name, DBConnInfoList.Where(x => x != CurrDBConnInfo).ToList()))
            {
                fm.ShowDialog(this);
            }
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            if (CurrDBConnInfo == null)
            {
                MessageBox.Show("請選擇資料庫");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtxtSQL.Text))
            {
                MessageBox.Show("語法空白");
                return;
            }

            try
            {
                var rslt = db.ExecuteNonQuery(rtxtSQL.Text);
                MessageBox.Show($"影響筆數:{rslt}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExecMulti_Click(object sender, EventArgs e)
        {
            using (var fm = new FmExecMulti(CurrDBConnInfo, rtxtSQL.Text, DBConnInfoList))
            {
                fm.ShowDialog(this);
            }
        }

        private void 個別檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirDlg = new FolderBrowserDialog();
            dirDlg.ShowDialog();
            var dir = dirDlg.SelectedPath;

            ProgressDialog pDialog = new ProgressDialog();
            pDialog.Title = "SQL物件轉出";
            pDialog.DoWork += delegate (object dialog, DoWorkEventArgs dwe)
            {
                var i = 1;
                foreach (DataGridViewRow row in DGVObject.Rows)
                {
                    var sqlObj = (SqlObject)row.DataBoundItem;
                    if (!string.IsNullOrEmpty(sqlObj.Definition))
                    {
                        SqlDefinition.ExportDefinitionToFile(CurrDBConnInfo, sqlObj.Name, $"{dir}\\{sqlObj.Name}.sql");
                    }

                    pDialog.ReportProgress(i++);
                }                
            };            
            pDialog.Completed += delegate (object dialog, RunWorkerCompletedEventArgs re) {
                MessageBox.Show("完成");
            };
            pDialog.Run(DGVObject.Rows.Count);
        }

        private void 合併為單檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exportStrs = new List<string>();
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "SQL|*.sql";
            saveFileDlg.Title = "轉出SQL檔案";
            saveFileDlg.ShowDialog();
            if (string.IsNullOrEmpty(saveFileDlg.FileName)) return;

            ProgressDialog pDialog = new ProgressDialog();
            pDialog.Title = "SQL物件轉出";
            pDialog.DoWork += delegate (object dialog, DoWorkEventArgs dwe)
            {
                var i = 1;
                foreach (DataGridViewRow row in DGVObject.Rows)
                {
                    var sqlObj = (SqlObject)row.DataBoundItem;
                    if (!string.IsNullOrEmpty(sqlObj.Definition))
                    {
                        exportStrs.Add($"if exists(select 1 from sys.sysobjects where name ='{sqlObj.Name}' and Type='{sqlObj.Type}')");
                        exportStrs.Add($"Drop {sqlObj.TypeFullName} [{sqlObj.Name}]");
                        exportStrs.Add("GO");
                        exportStrs.Add(SqlDefinition.GetDefinition(CurrDBConnInfo, sqlObj.Name));
                        exportStrs.Add("GO");
                        exportStrs.Add("");
                    }
                    pDialog.ReportProgress(i++);
                }

            };            
            pDialog.Completed += delegate (object dialog, RunWorkerCompletedEventArgs re) {

                var dir = Path.GetDirectoryName(saveFileDlg.FileName);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);                
                File.WriteAllText(saveFileDlg.FileName, string.Join(Environment.NewLine, exportStrs));
                MessageBox.Show("完成");
            };
            pDialog.Run(DGVObject.Rows.Count);
        }
    }
}
