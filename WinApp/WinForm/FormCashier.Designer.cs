namespace WinApp.WinForm
{
    partial class FormCashier
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbCardNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCash = new System.Windows.Forms.TextBox();
            this.tbxUnionPay = new System.Windows.Forms.TextBox();
            this.btnChooseCard = new System.Windows.Forms.Button();
            this.tbxOtherPayment = new System.Windows.Forms.TextBox();
            this.tbxCardPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbCardNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxCash);
            this.groupBox1.Controls.Add(this.tbxUnionPay);
            this.groupBox1.Controls.Add(this.btnChooseCard);
            this.groupBox1.Controls.Add(this.tbxOtherPayment);
            this.groupBox1.Controls.Add(this.tbxCardPayment);
            this.groupBox1.Location = new System.Drawing.Point(28, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 153);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "付款方式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "其他：";
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.ForeColor = System.Drawing.Color.Blue;
            this.lbCardNo.Location = new System.Drawing.Point(68, 127);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(29, 12);
            this.lbCardNo.TabIndex = 22;
            this.lbCardNo.Text = "0000";
            this.lbCardNo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "银联卡：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "会员卡：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "现金：";
            // 
            // tbxCash
            // 
            this.tbxCash.Location = new System.Drawing.Point(70, 19);
            this.tbxCash.MaxLength = 20;
            this.tbxCash.Name = "tbxCash";
            this.tbxCash.Size = new System.Drawing.Size(147, 21);
            this.tbxCash.TabIndex = 21;
            this.tbxCash.Text = "0.00";
            this.tbxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCash_KeyPress);
            // 
            // tbxUnionPay
            // 
            this.tbxUnionPay.Location = new System.Drawing.Point(70, 46);
            this.tbxUnionPay.MaxLength = 20;
            this.tbxUnionPay.Name = "tbxUnionPay";
            this.tbxUnionPay.Size = new System.Drawing.Size(147, 21);
            this.tbxUnionPay.TabIndex = 19;
            this.tbxUnionPay.Text = "0.00";
            this.tbxUnionPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUnionPay_KeyPress);
            // 
            // btnChooseCard
            // 
            this.btnChooseCard.Location = new System.Drawing.Point(221, 102);
            this.btnChooseCard.Name = "btnChooseCard";
            this.btnChooseCard.Size = new System.Drawing.Size(40, 23);
            this.btnChooseCard.TabIndex = 20;
            this.btnChooseCard.Text = "使用";
            this.btnChooseCard.UseVisualStyleBackColor = true;
            this.btnChooseCard.Click += new System.EventHandler(this.btnChooseCard_Click);
            // 
            // tbxOtherPayment
            // 
            this.tbxOtherPayment.Location = new System.Drawing.Point(70, 75);
            this.tbxOtherPayment.MaxLength = 20;
            this.tbxOtherPayment.Name = "tbxOtherPayment";
            this.tbxOtherPayment.Size = new System.Drawing.Size(147, 21);
            this.tbxOtherPayment.TabIndex = 19;
            this.tbxOtherPayment.Text = "0.00";
            this.tbxOtherPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOtherPayment_KeyPress);
            // 
            // tbxCardPayment
            // 
            this.tbxCardPayment.Location = new System.Drawing.Point(70, 103);
            this.tbxCardPayment.MaxLength = 20;
            this.tbxCardPayment.Name = "tbxCardPayment";
            this.tbxCardPayment.ReadOnly = true;
            this.tbxCardPayment.Size = new System.Drawing.Size(147, 21);
            this.tbxCardPayment.TabIndex = 19;
            this.tbxCardPayment.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "金额：";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnter.Location = new System.Drawing.Point(331, 202);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 60);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmount.Location = new System.Drawing.Point(97, 42);
            this.tbxAmount.MaxLength = 10;
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(223, 39);
            this.tbxAmount.TabIndex = 21;
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmount_KeyPress);
            this.tbxAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAmount_KeyUp);
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 314);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCashier";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "付款";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseCard;
        private System.Windows.Forms.TextBox tbxCardPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbxCash;
        private System.Windows.Forms.TextBox tbxUnionPay;
        private System.Windows.Forms.TextBox tbxOtherPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}