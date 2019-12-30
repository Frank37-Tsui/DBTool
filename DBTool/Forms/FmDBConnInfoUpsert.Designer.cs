namespace DBTool
{
    partial class FmDBConnInfoUpsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBtxt = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginPw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "資料庫描述";
            // 
            // txtDBtxt
            // 
            this.txtDBtxt.Location = new System.Drawing.Point(112, 21);
            this.txtDBtxt.Name = "txtDBtxt";
            this.txtDBtxt.Size = new System.Drawing.Size(205, 22);
            this.txtDBtxt.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(112, 58);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(205, 22);
            this.txtServer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "主機名";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(112, 95);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(205, 22);
            this.txtDBName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "資料庫名";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(112, 132);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(205, 22);
            this.txtLoginId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "登入帳號";
            // 
            // txtLoginPw
            // 
            this.txtLoginPw.Location = new System.Drawing.Point(112, 169);
            this.txtLoginPw.Name = "txtLoginPw";
            this.txtLoginPw.Size = new System.Drawing.Size(205, 22);
            this.txtLoginPw.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "登入密碼";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FmDBConnInfoUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 294);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLoginPw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDBtxt);
            this.Controls.Add(this.label1);
            this.Name = "FmDBConnInfoUpsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmDBConnInfoUpsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBtxt;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoginPw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}