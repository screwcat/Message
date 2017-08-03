namespace WinApp.WinForm.Admin
{
    partial class FormAddDiscount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAvailable = new System.Windows.Forms.RadioButton();
            this.rbNotAvailable = new System.Windows.Forms.RadioButton();
            this.tbxDiscountRate = new System.Windows.Forms.TextBox();
            this.tbxDisName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAvailable);
            this.groupBox1.Controls.Add(this.rbNotAvailable);
            this.groupBox1.Location = new System.Drawing.Point(48, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 29);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rbAvailable
            // 
            this.rbAvailable.AutoSize = true;
            this.rbAvailable.Checked = true;
            this.rbAvailable.Location = new System.Drawing.Point(4, 10);
            this.rbAvailable.Name = "rbAvailable";
            this.rbAvailable.Size = new System.Drawing.Size(47, 16);
            this.rbAvailable.TabIndex = 2;
            this.rbAvailable.TabStop = true;
            this.rbAvailable.Text = "可用";
            this.rbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbNotAvailable
            // 
            this.rbNotAvailable.AutoSize = true;
            this.rbNotAvailable.Location = new System.Drawing.Point(58, 10);
            this.rbNotAvailable.Name = "rbNotAvailable";
            this.rbNotAvailable.Size = new System.Drawing.Size(59, 16);
            this.rbNotAvailable.TabIndex = 3;
            this.rbNotAvailable.Text = "不可用";
            this.rbNotAvailable.UseVisualStyleBackColor = true;
            // 
            // tbxDiscountRate
            // 
            this.tbxDiscountRate.Location = new System.Drawing.Point(58, 56);
            this.tbxDiscountRate.Name = "tbxDiscountRate";
            this.tbxDiscountRate.Size = new System.Drawing.Size(106, 21);
            this.tbxDiscountRate.TabIndex = 1;
            this.tbxDiscountRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscountRate_KeyPress);
            // 
            // tbxDisName
            // 
            this.tbxDisName.Location = new System.Drawing.Point(58, 24);
            this.tbxDisName.Name = "tbxDisName";
            this.tbxDisName.Size = new System.Drawing.Size(106, 21);
            this.tbxDisName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "折扣：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "名称：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(166, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(166, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "*";
            // 
            // FormAddDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxDiscountRate);
            this.Controls.Add(this.tbxDisName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddDiscount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加折扣";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.RadioButton rbNotAvailable;
        private System.Windows.Forms.TextBox tbxDiscountRate;
        private System.Windows.Forms.TextBox tbxDisName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}