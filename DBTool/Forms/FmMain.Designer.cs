namespace DBTool
{
    partial class FmMain
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
            this.components = new System.ComponentModel.Container();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.DGVDBConnectInfo = new System.Windows.Forms.DataGridView();
            this.CMSDBConnectInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMIAddDBConnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVObject = new System.Windows.Forms.DataGridView();
            this.CMSSqlObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.檢視內容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCompare = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSync = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlCond = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVSqlResult = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.rtxtSQL = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLDBName = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.同步多處ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExec = new System.Windows.Forms.Button();
            this.BtnExecMulti = new System.Windows.Forms.Button();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDBConnectInfo)).BeginInit();
            this.CMSDBConnectInfo.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVObject)).BeginInit();
            this.CMSSqlObject.SuspendLayout();
            this.PnlCond.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSqlResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLeft.Controls.Add(this.DGVDBConnectInfo);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(200, 652);
            this.PnlLeft.TabIndex = 2;
            // 
            // DGVDBConnectInfo
            // 
            this.DGVDBConnectInfo.AllowUserToAddRows = false;
            this.DGVDBConnectInfo.AllowUserToDeleteRows = false;
            this.DGVDBConnectInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDBConnectInfo.ContextMenuStrip = this.CMSDBConnectInfo;
            this.DGVDBConnectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDBConnectInfo.Location = new System.Drawing.Point(0, 0);
            this.DGVDBConnectInfo.Name = "DGVDBConnectInfo";
            this.DGVDBConnectInfo.ReadOnly = true;
            this.DGVDBConnectInfo.RowTemplate.Height = 24;
            this.DGVDBConnectInfo.Size = new System.Drawing.Size(198, 650);
            this.DGVDBConnectInfo.TabIndex = 0;
            this.DGVDBConnectInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDBConnectInfo_CellMouseDoubleClick);
            // 
            // CMSDBConnectInfo
            // 
            this.CMSDBConnectInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAddDBConnInfo,
            this.修改ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.CMSDBConnectInfo.Name = "contextMenuStrip1";
            this.CMSDBConnectInfo.Size = new System.Drawing.Size(99, 70);
            // 
            // TSMIAddDBConnInfo
            // 
            this.TSMIAddDBConnInfo.Name = "TSMIAddDBConnInfo";
            this.TSMIAddDBConnInfo.Size = new System.Drawing.Size(98, 22);
            this.TSMIAddDBConnInfo.Text = "新增";
            this.TSMIAddDBConnInfo.Click += new System.EventHandler(this.TSMIAddDBConnInfo_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.panel2);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(200, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(966, 652);
            this.PnlMain.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 652);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 628);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVObject);
            this.tabPage1.Controls.Add(this.PnlCond);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL物件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVObject
            // 
            this.DGVObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVObject.ContextMenuStrip = this.CMSSqlObject;
            this.DGVObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVObject.Location = new System.Drawing.Point(3, 117);
            this.DGVObject.Name = "DGVObject";
            this.DGVObject.RowTemplate.Height = 24;
            this.DGVObject.Size = new System.Drawing.Size(952, 482);
            this.DGVObject.TabIndex = 4;
            // 
            // CMSSqlObject
            // 
            this.CMSSqlObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檢視內容ToolStripMenuItem,
            this.TsmiCompare,
            this.TsmiSync,
            this.同步多處ToolStripMenuItem});
            this.CMSSqlObject.Name = "CMSSqlObject";
            this.CMSSqlObject.Size = new System.Drawing.Size(123, 92);
            this.CMSSqlObject.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // 檢視內容ToolStripMenuItem
            // 
            this.檢視內容ToolStripMenuItem.Name = "檢視內容ToolStripMenuItem";
            this.檢視內容ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.檢視內容ToolStripMenuItem.Text = "檢視內容";
            this.檢視內容ToolStripMenuItem.Click += new System.EventHandler(this.檢視內容ToolStripMenuItem_Click);
            // 
            // TsmiCompare
            // 
            this.TsmiCompare.Name = "TsmiCompare";
            this.TsmiCompare.Size = new System.Drawing.Size(122, 22);
            this.TsmiCompare.Text = "比對";
            // 
            // TsmiSync
            // 
            this.TsmiSync.Name = "TsmiSync";
            this.TsmiSync.Size = new System.Drawing.Size(122, 22);
            this.TsmiSync.Text = "同步";
            this.TsmiSync.Click += new System.EventHandler(this.TsmiSync_Click);
            // 
            // PnlCond
            // 
            this.PnlCond.Controls.Add(this.button1);
            this.PnlCond.Controls.Add(this.label1);
            this.PnlCond.Controls.Add(this.TxtKeyword);
            this.PnlCond.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCond.Location = new System.Drawing.Point(3, 3);
            this.PnlCond.Name = "PnlCond";
            this.PnlCond.Size = new System.Drawing.Size(952, 114);
            this.PnlCond.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "關鍵字";
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Location = new System.Drawing.Point(62, 27);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(171, 22);
            this.TxtKeyword.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVSqlResult);
            this.tabPage2.Controls.Add(this.splitter2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.rtxtSQL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL語法";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVSqlResult
            // 
            this.DGVSqlResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSqlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSqlResult.Location = new System.Drawing.Point(3, 174);
            this.DGVSqlResult.Name = "DGVSqlResult";
            this.DGVSqlResult.RowTemplate.Height = 24;
            this.DGVSqlResult.Size = new System.Drawing.Size(952, 425);
            this.DGVSqlResult.TabIndex = 5;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(3, 164);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(952, 10);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExecMulti);
            this.panel1.Controls.Add(this.BtnExec);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 31);
            this.panel1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelect.Location = new System.Drawing.Point(0, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 31);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查詢";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // rtxtSQL
            // 
            this.rtxtSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtSQL.Location = new System.Drawing.Point(3, 3);
            this.rtxtSQL.Name = "rtxtSQL";
            this.rtxtSQL.Size = new System.Drawing.Size(952, 130);
            this.rtxtSQL.TabIndex = 0;
            this.rtxtSQL.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLName,
            this.tSSLServer,
            this.tSSLDBName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 24);
            this.statusStrip1.TabIndex = 10;
            // 
            // tSSLName
            // 
            this.tSSLName.AutoSize = false;
            this.tSSLName.Name = "tSSLName";
            this.tSSLName.Size = new System.Drawing.Size(200, 19);
            this.tSSLName.Text = "Name : ";
            this.tSSLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSSLServer
            // 
            this.tSSLServer.AutoSize = false;
            this.tSSLServer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSSLServer.Name = "tSSLServer";
            this.tSSLServer.Size = new System.Drawing.Size(200, 19);
            this.tSSLServer.Text = "Server : ";
            this.tSSLServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSSLDBName
            // 
            this.tSSLDBName.AutoSize = false;
            this.tSSLDBName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSSLDBName.Name = "tSSLDBName";
            this.tSSLDBName.Size = new System.Drawing.Size(200, 19);
            this.tSSLDBName.Text = "DBName : ";
            this.tSSLDBName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 652);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // 同步多處ToolStripMenuItem
            // 
            this.同步多處ToolStripMenuItem.Name = "同步多處ToolStripMenuItem";
            this.同步多處ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.同步多處ToolStripMenuItem.Text = "同步多處";
            this.同步多處ToolStripMenuItem.Click += new System.EventHandler(this.同步多處ToolStripMenuItem_Click);
            // 
            // BtnExec
            // 
            this.BtnExec.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnExec.Location = new System.Drawing.Point(75, 0);
            this.BtnExec.Name = "BtnExec";
            this.BtnExec.Size = new System.Drawing.Size(75, 31);
            this.BtnExec.TabIndex = 1;
            this.BtnExec.Text = "執行";
            this.BtnExec.UseVisualStyleBackColor = true;
            this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // BtnExecMulti
            // 
            this.BtnExecMulti.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnExecMulti.Location = new System.Drawing.Point(150, 0);
            this.BtnExecMulti.Name = "BtnExecMulti";
            this.BtnExecMulti.Size = new System.Drawing.Size(75, 31);
            this.BtnExecMulti.TabIndex = 2;
            this.BtnExecMulti.Text = "執行多處";
            this.BtnExecMulti.UseVisualStyleBackColor = true;
            this.BtnExecMulti.Click += new System.EventHandler(this.BtnExecMulti_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 652);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlLeft);
            this.Name = "FmMain";
            this.Text = "資料庫工具";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.PnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDBConnectInfo)).EndInit();
            this.CMSDBConnectInfo.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVObject)).EndInit();
            this.CMSSqlObject.ResumeLayout(false);
            this.PnlCond.ResumeLayout(false);
            this.PnlCond.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSqlResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.ContextMenuStrip CMSDBConnectInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIAddDBConnInfo;
        private System.Windows.Forms.DataGridView DGVDBConnectInfo;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip CMSSqlObject;
        private System.Windows.Forms.ToolStripMenuItem 檢視內容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiCompare;
        private System.Windows.Forms.ToolStripMenuItem TsmiSync;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVObject;
        private System.Windows.Forms.Panel PnlCond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVSqlResult;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RichTextBox rtxtSQL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLServer;
        private System.Windows.Forms.ToolStripStatusLabel tSSLDBName;
        private System.Windows.Forms.ToolStripStatusLabel tSSLName;
        private System.Windows.Forms.ToolStripMenuItem 同步多處ToolStripMenuItem;
        private System.Windows.Forms.Button BtnExecMulti;
        private System.Windows.Forms.Button BtnExec;
    }
}

