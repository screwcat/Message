namespace WinApp.WinForm
{
    partial class FormBackPassword
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
            this.tbxBackPwd = new System.Windows.Forms.TextBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbWrongPwd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxBackPwd
            // 
            this.tbxBackPwd.Location = new System.Drawing.Point(12, 15);
            this.tbxBackPwd.MaxLength = 20;
            this.tbxBackPwd.Name = "tbxBackPwd";
            this.tbxBackPwd.Size = new System.Drawing.Size(169, 21);
            this.tbxBackPwd.TabIndex = 0;
            this.tbxBackPwd.UseSystemPasswordChar = true;
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(187, 13);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(42, 23);
            this.btnDetermine.TabIndex = 1;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 22);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbWrongPwd
            // 
            this.lbWrongPwd.AutoSize = true;
            this.lbWrongPwd.ForeColor = System.Drawing.Color.Red;
            this.lbWrongPwd.Location = new System.Drawing.Point(12, 38);
            this.lbWrongPwd.Name = "lbWrongPwd";
            this.lbWrongPwd.Size = new System.Drawing.Size(77, 12);
            this.lbWrongPwd.TabIndex = 3;
            this.lbWrongPwd.Text = "密码不正确！";
            this.lbWrongPwd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入操作密码";
            // 
            // FormBackPassword
            // 
            this.AcceptButton = this.btnDetermine;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(291, 53);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWrongPwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.tbxBackPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormBackPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBackSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBackPwd;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbWrongPwd;
        private System.Windows.Forms.Label label1;
    }
}