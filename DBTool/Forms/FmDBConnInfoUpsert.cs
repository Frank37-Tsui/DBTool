using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTool
{
    public partial class FmDBConnInfoUpsert : Form
    {
        private DBConnInfo connInfo;
        private MaintainMode maintainMode;
        public FmDBConnInfoUpsert(DBConnInfo info)
        {
            if (info == null)
            {
                this.connInfo = new DBConnInfo();
                maintainMode = MaintainMode.Create;
            }
            else
            {
                this.connInfo = info;
                maintainMode = MaintainMode.Update;
            }
            
            InitializeComponent();
            txtDBtxt.DataBindings.Add("Text", connInfo, "DBTxt", true);
            txtServer.DataBindings.Add("Text", connInfo, "Server", true);
            txtDBName.DataBindings.Add("Text", connInfo, "DBName", true);
            txtLoginId.DataBindings.Add("Text", connInfo, "LoginId", true);
            txtLoginPw.DataBindings.Add("Text", connInfo, "LoginPw", true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (maintainMode == MaintainMode.Create)
            {
                DBConnInfoRepo.GetInstance().Add(connInfo);
            }
            else
            {
                DBConnInfoRepo.GetInstance().Update(connInfo);
            }
            
            Close();
        }
    }

    public enum MaintainMode
    {
        Create,
        Update
    }
}
