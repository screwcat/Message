namespace WinApp.WinForm.Admin
{
    partial class FormRecharge
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
            this.tbxRechargeAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRechargeAmount
            // 
            this.tbxRechargeAmount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRechargeAmount.ForeColor = System.Drawing.Color.Red;
            this.tbxRechargeAmount.Location = new System.Drawing.Point(113, 51);
            this.tbxRechargeAmount.MaxLength = 10;
            this.tbxRechargeAmount.Name = "tbxRechargeAmount";
            this.tbxRechargeAmount.Size = new System.Drawing.Size(156, 35);
            this.tbxRechargeAmount.TabIndex = 0;
            this.tbxRechargeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRechargeAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入充值金额：";
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(281, 58);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 2;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // FormRecharge
            // 
            this.AcceptButton = this.btnDetermine;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 150);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRechargeAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRecharge";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRechargeAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetermine;
    }
}