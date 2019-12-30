namespace DBTool.Forms
{
    partial class FmExecMulti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlHead = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnSyncMulti = new System.Windows.Forms.Button();
            this.rTxtSQL = new System.Windows.Forms.RichTextBox();
            this.PnlHead.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.Controls.Add(this.rTxtSQL);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(640, 128);
            this.PnlHead.TabIndex = 0;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.tabControl1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 128);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(640, 416);
            this.PnlMain.TabIndex = 1;
            this.PnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMain_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 416);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料庫清單";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "qweljkweqdnadewqewqewq321321321"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(626, 384);
            this.checkedListBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "同步狀況";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 410);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // PnlFooter
            // 
            this.PnlFooter.Controls.Add(this.BtnSyncMulti);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 497);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(640, 47);
            this.PnlFooter.TabIndex = 2;
            // 
            // BtnSyncMulti
            // 
            this.BtnSyncMulti.Location = new System.Drawing.Point(272, 12);
            this.BtnSyncMulti.Name = "BtnSyncMulti";
            this.BtnSyncMulti.Size = new System.Drawing.Size(75, 23);
            this.BtnSyncMulti.TabIndex = 0;
            this.BtnSyncMulti.Text = "執行";
            this.BtnSyncMulti.UseVisualStyleBackColor = true;
            this.BtnSyncMulti.Click += new System.EventHandler(this.BtnSyncMulti_Click);
            // 
            // rTxtSQL
            // 
            this.rTxtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtSQL.Location = new System.Drawing.Point(0, 0);
            this.rTxtSQL.Name = "rTxtSQL";
            this.rTxtSQL.Size = new System.Drawing.Size(640, 128);
            this.rTxtSQL.TabIndex = 0;
            this.rTxtSQL.Text = "";
            // 
            // FmExecMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 544);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlHead);
            this.Name = "FmExecMulti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmSyncMulti";
            this.PnlHead.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.PnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHead;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Button BtnSyncMulti;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rTxtSQL;
    }
}