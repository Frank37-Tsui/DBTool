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
    public partial class FmObjDefinition : Form
    {
        public string ObjName { get; }
        public string ObjDefinition { get; }
        public FmObjDefinition(string objName, string objDefinition)
        {                        
            ObjName = objName;
            ObjDefinition = objDefinition;
            InitializeComponent();
            richTextBox1.Text = ObjDefinition;

            this.Text = objName;
        }
    }
}
