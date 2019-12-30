using DBHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTool.Forms
{
    public partial class FmExecMulti : Form
    {
        public DBConnInfo SourInfo { get; }
        private readonly List<DBConnInfo> otherInfos;
        public FmExecMulti(DBConnInfo sourInfo, string sql, List<DBConnInfo> otherInfos)
        {
            SourInfo = sourInfo;
            this.otherInfos = otherInfos;
            InitializeComponent();
            this.Text = $"來源主機 : {SourInfo.FullName}";
            rTxtSQL.Text = sql;
            checkedListBox1.DataSource = this.otherInfos;
            checkedListBox1.ValueMember = "Id";
            checkedListBox1.DisplayMember = "FullName";
        }

        private void BtnSyncMulti_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            richTextBox1.Clear();            
            foreach (var item in checkedListBox1.CheckedItems)
            {
                var trgtDBInfo = (DBConnInfo)item;
                try
                {
                    richTextBox1.AppendText($"在 {trgtDBInfo.FullName} 執行 開始{Environment.NewLine}");
                    var db = new DBHelper(SqlClientFactory.Instance, trgtDBInfo.GetConnectionString());
                    var rslt = db.ExecuteNonQuery(rTxtSQL.Text);                    
                    richTextBox1.AppendText($"在 {trgtDBInfo.FullName} 執行 完成，影響筆數 : {rslt}{Environment.NewLine}");
                }
                catch (Exception ex)
                {
                    richTextBox1.AppendText($"在 {trgtDBInfo.FullName} 執行 失敗，{ex.Message}{Environment.NewLine}");
                }                                           
            }
            MessageBox.Show("已完成");
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
