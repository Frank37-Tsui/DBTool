using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTool.Forms
{
    public partial class FmSyncMulti : Form
    {
        public DBConnInfo SourInfo { get; }
        public string ObjName { get; }
        private readonly List<DBConnInfo> otherInfos;
        public FmSyncMulti(DBConnInfo sourInfo, string objName, List<DBConnInfo> otherInfos)
        {
            SourInfo = sourInfo;
            ObjName = objName;
            this.otherInfos = otherInfos;
            InitializeComponent();
            this.Text = $"來源主機 : {SourInfo.FullName}";
            textBox1.Text = ObjName;
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
                    richTextBox1.AppendText($"同步到 {trgtDBInfo.FullName} 開始{Environment.NewLine}");
                    SqlDefinition.SyncObj(SourInfo, (DBConnInfo)item, ObjName);
                    richTextBox1.AppendText($"同步到 {trgtDBInfo.FullName} 完成{Environment.NewLine}");
                }
                catch (Exception ex)
                {
                    richTextBox1.AppendText($"同步到 {trgtDBInfo.FullName} 失敗，{ex.Message}{Environment.NewLine}");
                }
                this.Update();
            }
            MessageBox.Show("已完成");
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
