namespace WinApp.WinForm
{
    partial class FormMemCard
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
            this.tbxCardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbLastUse = new System.Windows.Forms.Label();
            this.lbHandleTime = new System.Windows.Forms.Label();
            this.lbUserTel = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbCardType = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCannotFind = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCardNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxConsumption = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxCardNo
            // 
            this.tbxCardNo.Location = new System.Drawing.Point(109, 14);
            this.tbxCardNo.MaxLength = 20;
            this.tbxCardNo.Name = "tbxCardNo";
            this.tbxCardNo.Size = new System.Drawing.Size(205, 21);
            this.tbxCardNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "会员卡种类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓    名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "电    话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "办 理 时 间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "上 次 使 用：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "余    额：";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.ForeColor = System.Drawing.Color.Blue;
            this.lbBalance.Location = new System.Drawing.Point(114, 245);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(0, 12);
            this.lbBalance.TabIndex = 13;
            // 
            // lbLastUse
            // 
            this.lbLastUse.AutoSize = true;
            this.lbLastUse.ForeColor = System.Drawing.Color.Blue;
            this.lbLastUse.Location = new System.Drawing.Point(114, 219);
            this.lbLastUse.Name = "lbLastUse";
            this.lbLastUse.Size = new System.Drawing.Size(0, 12);
            this.lbLastUse.TabIndex = 12;
            // 
            // lbHandleTime
            // 
            this.lbHandleTime.AutoSize = true;
            this.lbHandleTime.ForeColor = System.Drawing.Color.Blue;
            this.lbHandleTime.Location = new System.Drawing.Point(114, 192);
            this.lbHandleTime.Name = "lbHandleTime";
            this.lbHandleTime.Size = new System.Drawing.Size(0, 12);
            this.lbHandleTime.TabIndex = 11;
            // 
            // lbUserTel
            // 
            this.lbUserTel.AutoSize = true;
            this.lbUserTel.ForeColor = System.Drawing.Color.Blue;
            this.lbUserTel.Location = new System.Drawing.Point(114, 169);
            this.lbUserTel.Name = "lbUserTel";
            this.lbUserTel.Size = new System.Drawing.Size(0, 12);
            this.lbUserTel.TabIndex = 10;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.ForeColor = System.Drawing.Color.Blue;
            this.lbMemberName.Location = new System.Drawing.Point(114, 142);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(0, 12);
            this.lbMemberName.TabIndex = 9;
            // 
            // lbCardType
            // 
            this.lbCardType.AutoSize = true;
            this.lbCardType.ForeColor = System.Drawing.Color.Blue;
            this.lbCardType.Location = new System.Drawing.Point(114, 117);
            this.lbCardType.Name = "lbCardType";
            this.lbCardType.Size = new System.Drawing.Size(0, 12);
            this.lbCardType.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(331, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCannotFind
            // 
            this.lbCannotFind.AutoSize = true;
            this.lbCannotFind.ForeColor = System.Drawing.Color.Red;
            this.lbCannotFind.Location = new System.Drawing.Point(103, 41);
            this.lbCannotFind.Name = "lbCannotFind";
            this.lbCannotFind.Size = new System.Drawing.Size(113, 12);
            this.lbCannotFind.TabIndex = 15;
            this.lbCannotFind.Text = "找不到该卡号信息！";
            this.lbCannotFind.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "卡    号：";
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.ForeColor = System.Drawing.Color.Blue;
            this.lbCardNo.Location = new System.Drawing.Point(114, 94);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(0, 12);
            this.lbCardNo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "本次消费：";
            // 
            // tbxConsumption
            // 
            this.tbxConsumption.Location = new System.Drawing.Point(293, 240);
            this.tbxConsumption.MaxLength = 10;
            this.tbxConsumption.Name = "tbxConsumption";
            this.tbxConsumption.Size = new System.Drawing.Size(100, 21);
            this.tbxConsumption.TabIndex = 16;
            this.tbxConsumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxlbConsumption_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "金    额：";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.ForeColor = System.Drawing.Color.Blue;
            this.lbAmount.Location = new System.Drawing.Point(114, 73);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(0, 12);
            this.lbAmount.TabIndex = 8;
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(345, 285);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(88, 30);
            this.btnDetermine.TabIndex = 17;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // FormMemCard
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 333);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.tbxConsumption);
            this.Controls.Add(this.lbCannotFind);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbLastUse);
            this.Controls.Add(this.lbHandleTime);
            this.Controls.Add(this.lbUserTel);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.lbCardType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCardNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMemCard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择会员卡";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbLastUse;
        private System.Windows.Forms.Label lbHandleTime;
        private System.Windows.Forms.Label lbUserTel;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCardType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbCannotFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxConsumption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnDetermine;
    }
}