namespace WinApp.WinForm.Admin
{
    partial class FormMemCardDtl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemCardDtl));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCardNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUserTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxHandleTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLastUse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPage1 = new WinApp.Controls.UCPage();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号：";
            // 
            // tbxCardNo
            // 
            this.tbxCardNo.Location = new System.Drawing.Point(552, 30);
            this.tbxCardNo.Name = "tbxCardNo";
            this.tbxCardNo.ReadOnly = true;
            this.tbxCardNo.Size = new System.Drawing.Size(155, 21);
            this.tbxCardNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // tbxMemberName
            // 
            this.tbxMemberName.Location = new System.Drawing.Point(552, 65);
            this.tbxMemberName.MaxLength = 20;
            this.tbxMemberName.Name = "tbxMemberName";
            this.tbxMemberName.Size = new System.Drawing.Size(155, 21);
            this.tbxMemberName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "联系电话：";
            // 
            // tbxUserTel
            // 
            this.tbxUserTel.Location = new System.Drawing.Point(552, 134);
            this.tbxUserTel.MaxLength = 20;
            this.tbxUserTel.Name = "tbxUserTel";
            this.tbxUserTel.Size = new System.Drawing.Size(155, 21);
            this.tbxUserTel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "办卡时间：";
            // 
            // tbxHandleTime
            // 
            this.tbxHandleTime.Location = new System.Drawing.Point(552, 166);
            this.tbxHandleTime.Name = "tbxHandleTime";
            this.tbxHandleTime.ReadOnly = true;
            this.tbxHandleTime.Size = new System.Drawing.Size(155, 21);
            this.tbxHandleTime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "最后使用时间：";
            // 
            // tbxLastUse
            // 
            this.tbxLastUse.Location = new System.Drawing.Point(552, 198);
            this.tbxLastUse.Name = "tbxLastUse";
            this.tbxLastUse.ReadOnly = true;
            this.tbxLastUse.Size = new System.Drawing.Size(155, 21);
            this.tbxLastUse.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "余额：";
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(552, 232);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(155, 21);
            this.tbxBalance.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MB,
            this.OpeTime,
            this.RecType,
            this.Amount,
            this.TradeNo});
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(447, 372);
            this.dataGridView1.TabIndex = 5;
            // 
            // MB
            // 
            this.MB.DataPropertyName = "MB";
            this.MB.HeaderText = "序号";
            this.MB.Name = "MB";
            this.MB.ReadOnly = true;
            this.MB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MB.Width = 50;
            // 
            // OpeTime
            // 
            this.OpeTime.DataPropertyName = "OpeTime";
            this.OpeTime.HeaderText = "日期";
            this.OpeTime.Name = "OpeTime";
            this.OpeTime.ReadOnly = true;
            this.OpeTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OpeTime.Width = 110;
            // 
            // RecType
            // 
            this.RecType.DataPropertyName = "RecType";
            this.RecType.HeaderText = "操作";
            this.RecType.Name = "RecType";
            this.RecType.ReadOnly = true;
            this.RecType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RecType.Width = 80;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "金额";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TradeNo
            // 
            this.TradeNo.DataPropertyName = "TradeNo";
            this.TradeNo.HeaderText = "单号";
            this.TradeNo.Name = "TradeNo";
            this.TradeNo.ReadOnly = true;
            this.TradeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TradeNo.Width = 85;
            // 
            // ucPage1
            // 
            this.ucPage1.CurPage = 1;
            this.ucPage1.DataSetSql = "";
            this.ucPage1.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiOrder")));
            this.ucPage1.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiWhere")));
            this.ucPage1.Location = new System.Drawing.Point(12, 414);
            this.ucPage1.Name = "ucPage1";
            this.ucPage1.PageSize = 20;
            this.ucPage1.Size = new System.Drawing.Size(532, 27);
            this.ucPage1.TabIndex = 7;
            // 
            // cbCardType
            // 
            this.cbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Location = new System.Drawing.Point(552, 99);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(155, 20);
            this.cbCardType.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(636, 355);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(470, 355);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(75, 23);
            this.btnRecharge.TabIndex = 10;
            this.btnRecharge.Text = "充值";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(708, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(708, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "*";
            // 
            // tbxRemarks
            // 
            this.tbxRemarks.Location = new System.Drawing.Point(552, 266);
            this.tbxRemarks.MaxLength = 200;
            this.tbxRemarks.Multiline = true;
            this.tbxRemarks.Name = "tbxRemarks";
            this.tbxRemarks.Size = new System.Drawing.Size(155, 54);
            this.tbxRemarks.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "备注：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 401);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "交易记录";
            // 
            // FormMemCardDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxRemarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCardType);
            this.Controls.Add(this.ucPage1);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.tbxLastUse);
            this.Controls.Add(this.tbxHandleTime);
            this.Controls.Add(this.tbxUserTel);
            this.Controls.Add(this.tbxMemberName);
            this.Controls.Add(this.tbxCardNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMemCardDtl";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员卡信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCardNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUserTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxHandleTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxLastUse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.UCPage ucPage1;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeNo;
    }
}