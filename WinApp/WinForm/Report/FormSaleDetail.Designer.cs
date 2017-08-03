namespace WinApp.WinForm.Report
{
    partial class FormSaleDetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTradeNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSaleDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbMbName = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbStoreHouse_ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrintAgain = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCheckoutTime = new System.Windows.Forms.Label();
            this.tbxCash = new System.Windows.Forms.TextBox();
            this.tbxUnionPay = new System.Windows.Forms.TextBox();
            this.tbxMemCard = new System.Windows.Forms.TextBox();
            this.tbxOtherPayment = new System.Windows.Forms.TextBox();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbOrderNo = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidIn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Detail_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Code,
            this.ProCode,
            this.ProName,
            this.Price,
            this.Quantity,
            this.Discount,
            this.PaidIn1,
            this.PaidInAmount,
            this.ServerName,
            this.Sale_Detail_ID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 425);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "流水号：";
            // 
            // lbTradeNo
            // 
            this.lbTradeNo.AutoSize = true;
            this.lbTradeNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTradeNo.Location = new System.Drawing.Point(745, 45);
            this.lbTradeNo.Name = "lbTradeNo";
            this.lbTradeNo.Size = new System.Drawing.Size(68, 12);
            this.lbTradeNo.TabIndex = 5;
            this.lbTradeNo.Text = "lbTradeNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "开单时间：";
            // 
            // lbSaleDate
            // 
            this.lbSaleDate.AutoSize = true;
            this.lbSaleDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSaleDate.Location = new System.Drawing.Point(745, 141);
            this.lbSaleDate.Name = "lbSaleDate";
            this.lbSaleDate.Size = new System.Drawing.Size(75, 12);
            this.lbSaleDate.TabIndex = 5;
            this.lbSaleDate.Text = "lbSaleDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "现金：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "银联卡：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "会员卡：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(650, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "其他支付方式：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(674, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "会员卡号：";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAccount.Location = new System.Drawing.Point(745, 327);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(68, 12);
            this.lbAccount.TabIndex = 5;
            this.lbAccount.Text = "lbAccount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(686, 353);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "持卡人：";
            // 
            // lbMbName
            // 
            this.lbMbName.AutoSize = true;
            this.lbMbName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMbName.Location = new System.Drawing.Point(745, 353);
            this.lbMbName.Name = "lbMbName";
            this.lbMbName.Size = new System.Drawing.Size(61, 12);
            this.lbMbName.TabIndex = 5;
            this.lbMbName.Text = "lbMbName";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(686, 379);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 5;
            this.label19.Text = "操作员：";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEmployeeName.Location = new System.Drawing.Point(745, 379);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(103, 12);
            this.lbEmployeeName.TabIndex = 5;
            this.lbEmployeeName.Text = "lbEmployeeName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "共计：";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalAmount.Location = new System.Drawing.Point(745, 298);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(96, 12);
            this.lbTotalAmount.TabIndex = 5;
            this.lbTotalAmount.Text = "lbTotalAmount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "顾客号：";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCustomer.Location = new System.Drawing.Point(745, 90);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(75, 12);
            this.lbCustomer.TabIndex = 5;
            this.lbCustomer.Text = "lbCustomer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "房间号：";
            // 
            // lbStoreHouse_ID
            // 
            this.lbStoreHouse_ID.AutoSize = true;
            this.lbStoreHouse_ID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStoreHouse_ID.Location = new System.Drawing.Point(745, 115);
            this.lbStoreHouse_ID.Name = "lbStoreHouse_ID";
            this.lbStoreHouse_ID.Size = new System.Drawing.Size(110, 12);
            this.lbStoreHouse_ID.TabIndex = 5;
            this.lbStoreHouse_ID.Text = "lbStoreHouse_ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrintAgain
            // 
            this.btnPrintAgain.Location = new System.Drawing.Point(704, 460);
            this.btnPrintAgain.Name = "btnPrintAgain";
            this.btnPrintAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPrintAgain.TabIndex = 6;
            this.btnPrintAgain.Text = "再次打印";
            this.btnPrintAgain.UseVisualStyleBackColor = true;
            this.btnPrintAgain.Click += new System.EventHandler(this.btnPrintAgain_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "结帐时间：";
            // 
            // lbCheckoutTime
            // 
            this.lbCheckoutTime.AutoSize = true;
            this.lbCheckoutTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCheckoutTime.Location = new System.Drawing.Point(745, 168);
            this.lbCheckoutTime.Name = "lbCheckoutTime";
            this.lbCheckoutTime.Size = new System.Drawing.Size(103, 12);
            this.lbCheckoutTime.TabIndex = 5;
            this.lbCheckoutTime.Text = "lbCheckoutTime";
            // 
            // tbxCash
            // 
            this.tbxCash.Location = new System.Drawing.Point(735, 190);
            this.tbxCash.Name = "tbxCash";
            this.tbxCash.Size = new System.Drawing.Size(137, 21);
            this.tbxCash.TabIndex = 7;
            this.tbxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCash_KeyPress);
            // 
            // tbxUnionPay
            // 
            this.tbxUnionPay.Location = new System.Drawing.Point(735, 216);
            this.tbxUnionPay.Name = "tbxUnionPay";
            this.tbxUnionPay.Size = new System.Drawing.Size(137, 21);
            this.tbxUnionPay.TabIndex = 7;
            this.tbxUnionPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUnionPay_KeyPress);
            // 
            // tbxMemCard
            // 
            this.tbxMemCard.Location = new System.Drawing.Point(735, 241);
            this.tbxMemCard.Name = "tbxMemCard";
            this.tbxMemCard.Size = new System.Drawing.Size(137, 21);
            this.tbxMemCard.TabIndex = 7;
            this.tbxMemCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMemCard_KeyPress);
            // 
            // tbxOtherPayment
            // 
            this.tbxOtherPayment.Location = new System.Drawing.Point(735, 267);
            this.tbxOtherPayment.Name = "tbxOtherPayment";
            this.tbxOtherPayment.Size = new System.Drawing.Size(137, 21);
            this.tbxOtherPayment.TabIndex = 7;
            this.tbxOtherPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOtherPayment_KeyPress);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(609, 460);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChange.TabIndex = 6;
            this.btnSaveChange.Text = "保存更改";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "单号：";
            // 
            // lbOrderNo
            // 
            this.lbOrderNo.AutoSize = true;
            this.lbOrderNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOrderNo.Location = new System.Drawing.Point(745, 68);
            this.lbOrderNo.Name = "lbOrderNo";
            this.lbOrderNo.Size = new System.Drawing.Size(68, 12);
            this.lbOrderNo.TabIndex = 5;
            this.lbOrderNo.Text = "lbOrderNo";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "ListNO";
            this.Code.HeaderText = "序号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Code.Width = 50;
            // 
            // ProCode
            // 
            this.ProCode.DataPropertyName = "Code";
            this.ProCode.HeaderText = "代码";
            this.ProCode.Name = "ProCode";
            this.ProCode.ReadOnly = true;
            this.ProCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProCode.Width = 60;
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "ProductName";
            this.ProName.HeaderText = "名称";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            this.ProName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProName.Width = 112;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 60;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Discount.Width = 60;
            // 
            // PaidIn1
            // 
            this.PaidIn1.DataPropertyName = "PaidIn1";
            this.PaidIn1.HeaderText = "实收";
            this.PaidIn1.Name = "PaidIn1";
            this.PaidIn1.ReadOnly = true;
            this.PaidIn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PaidIn1.Width = 60;
            // 
            // PaidInAmount
            // 
            this.PaidInAmount.DataPropertyName = "PaidInAmount";
            this.PaidInAmount.HeaderText = "金额";
            this.PaidInAmount.Name = "PaidInAmount";
            this.PaidInAmount.ReadOnly = true;
            this.PaidInAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PaidInAmount.Width = 70;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "ServerName";
            this.ServerName.HeaderText = "服务人员";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            this.ServerName.Width = 80;
            // 
            // Sale_Detail_ID
            // 
            this.Sale_Detail_ID.DataPropertyName = "Sale_Detail_ID";
            this.Sale_Detail_ID.HeaderText = "Sale_Detail_ID";
            this.Sale_Detail_ID.Name = "Sale_Detail_ID";
            this.Sale_Detail_ID.ReadOnly = true;
            this.Sale_Detail_ID.Visible = false;
            // 
            // FormSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 510);
            this.Controls.Add(this.tbxOtherPayment);
            this.Controls.Add(this.tbxMemCard);
            this.Controls.Add(this.tbxUnionPay);
            this.Controls.Add(this.tbxCash);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnPrintAgain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbMbName);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbCheckoutTime);
            this.Controls.Add(this.lbSaleDate);
            this.Controls.Add(this.lbStoreHouse_ID);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbOrderNo);
            this.Controls.Add(this.lbTradeNo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSaleDetail";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSaleDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTradeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSaleDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbMbName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStoreHouse_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrintAgain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCheckoutTime;
        private System.Windows.Forms.TextBox tbxCash;
        private System.Windows.Forms.TextBox tbxUnionPay;
        private System.Windows.Forms.TextBox tbxMemCard;
        private System.Windows.Forms.TextBox tbxOtherPayment;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidIn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Detail_ID;
    }
}