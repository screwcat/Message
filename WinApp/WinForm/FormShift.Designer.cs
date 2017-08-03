namespace WinApp.WinForm
{
    partial class FormShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShift));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCash = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMembershipCard = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUnionPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOther = new System.Windows.Forms.Label();
            this.btnShift = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCommission = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxOrderNoDtl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbProName = new System.Windows.Forms.ComboBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDtlSearch = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtlCheckoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Detail_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalAmountDtl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCommissionDtl = new System.Windows.Forms.Label();
            this.ucPage1 = new WinApp.Controls.UCPage();
            this.ucPage2 = new WinApp.Controls.UCPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
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
            this.TradeNo,
            this.OrderNo,
            this.CheckoutTime,
            this.TotalAmount,
            this.Customer,
            this.OptName,
            this.Sale_ID});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(607, 416);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "MB";
            this.Code.HeaderText = "序号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Code.Width = 50;
            // 
            // TradeNo
            // 
            this.TradeNo.DataPropertyName = "TradeNo";
            this.TradeNo.HeaderText = "流水号";
            this.TradeNo.Name = "TradeNo";
            this.TradeNo.ReadOnly = true;
            this.TradeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderNo
            // 
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "单号";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CheckoutTime
            // 
            this.CheckoutTime.DataPropertyName = "CheckoutTime";
            this.CheckoutTime.HeaderText = "结帐时间";
            this.CheckoutTime.Name = "CheckoutTime";
            this.CheckoutTime.ReadOnly = true;
            this.CheckoutTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CheckoutTime.Width = 120;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "金额";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalAmount.Width = 80;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "顾客号";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Customer.Width = 70;
            // 
            // OptName
            // 
            this.OptName.DataPropertyName = "Name";
            this.OptName.HeaderText = "操作员";
            this.OptName.Name = "OptName";
            this.OptName.ReadOnly = true;
            this.OptName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OptName.Width = 80;
            // 
            // Sale_ID
            // 
            this.Sale_ID.DataPropertyName = "Sale_ID";
            this.Sale_ID.HeaderText = "Sale_ID";
            this.Sale_ID.Name = "Sale_ID";
            this.Sale_ID.ReadOnly = true;
            this.Sale_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "共计金额：";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(70, 460);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(83, 12);
            this.lbTotalAmount.TabIndex = 23;
            this.lbTotalAmount.Text = "lbTotalAmount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "现金：";
            // 
            // lbCash
            // 
            this.lbCash.AutoSize = true;
            this.lbCash.Location = new System.Drawing.Point(48, 478);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(41, 12);
            this.lbCash.TabIndex = 23;
            this.lbCash.Text = "lbCash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "会员卡：";
            // 
            // lbMembershipCard
            // 
            this.lbMembershipCard.AutoSize = true;
            this.lbMembershipCard.Location = new System.Drawing.Point(173, 478);
            this.lbMembershipCard.Name = "lbMembershipCard";
            this.lbMembershipCard.Size = new System.Drawing.Size(101, 12);
            this.lbMembershipCard.TabIndex = 23;
            this.lbMembershipCard.Text = "lbMembershipCard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "银联卡：";
            // 
            // lbUnionPay
            // 
            this.lbUnionPay.AutoSize = true;
            this.lbUnionPay.Location = new System.Drawing.Point(360, 478);
            this.lbUnionPay.Name = "lbUnionPay";
            this.lbUnionPay.Size = new System.Drawing.Size(65, 12);
            this.lbUnionPay.TabIndex = 23;
            this.lbUnionPay.Text = "lbUnionPay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "其他：";
            // 
            // lbOther
            // 
            this.lbOther.AutoSize = true;
            this.lbOther.Location = new System.Drawing.Point(509, 478);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(47, 12);
            this.lbOther.TabIndex = 23;
            this.lbOther.Text = "lbOther";
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(547, 551);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(75, 23);
            this.btnShift.TabIndex = 24;
            this.btnShift.Text = "确定交班";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "提成：";
            // 
            // lbCommission
            // 
            this.lbCommission.AutoSize = true;
            this.lbCommission.Location = new System.Drawing.Point(48, 497);
            this.lbCommission.Name = "lbCommission";
            this.lbCommission.Size = new System.Drawing.Size(77, 12);
            this.lbCommission.TabIndex = 23;
            this.lbCommission.Text = "lbCommission";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 541);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.ucPage1);
            this.tabPage1.Controls.Add(this.lbOther);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbUnionPay);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbMembershipCard);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbTotalAmount);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lbCommission);
            this.tabPage1.Controls.Add(this.lbCash);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "汇总";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.lbCommissionDtl);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbTotalAmountDtl);
            this.tabPage2.Controls.Add(this.ucPage2);
            this.tabPage2.Controls.Add(this.dgvDetail);
            this.tabPage2.Controls.Add(this.tbxOrderNoDtl);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cbProName);
            this.tabPage2.Controls.Add(this.cbServer);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnDtlSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "明细";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxOrderNoDtl
            // 
            this.tbxOrderNoDtl.Location = new System.Drawing.Point(393, 7);
            this.tbxOrderNoDtl.Name = "tbxOrderNoDtl";
            this.tbxOrderNoDtl.Size = new System.Drawing.Size(122, 21);
            this.tbxOrderNoDtl.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "单号：";
            // 
            // cbProName
            // 
            this.cbProName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProName.FormattingEnabled = true;
            this.cbProName.Location = new System.Drawing.Point(43, 10);
            this.cbProName.Name = "cbProName";
            this.cbProName.Size = new System.Drawing.Size(121, 20);
            this.cbProName.TabIndex = 47;
            // 
            // cbServer
            // 
            this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(236, 9);
            this.cbServer.MaxDropDownItems = 100;
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(107, 20);
            this.cbServer.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "服务人员：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "品名：";
            // 
            // btnDtlSearch
            // 
            this.btnDtlSearch.Location = new System.Drawing.Point(528, 5);
            this.btnDtlSearch.Name = "btnDtlSearch";
            this.btnDtlSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDtlSearch.TabIndex = 43;
            this.btnDtlSearch.Text = "查找";
            this.btnDtlSearch.UseVisualStyleBackColor = true;
            this.btnDtlSearch.Click += new System.EventHandler(this.btnDtlSearch_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeColumns = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Total,
            this.Commission,
            this.ServerName,
            this.dtlOrderNo,
            this.DtlCheckoutTime,
            this.Sale_Detail_ID});
            this.dgvDetail.Location = new System.Drawing.Point(4, 35);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(614, 418);
            this.dgvDetail.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MB";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "品名";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductName.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 60;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 40;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "实收金额";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 70;
            // 
            // Commission
            // 
            this.Commission.DataPropertyName = "Commission";
            this.Commission.HeaderText = "提成";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            this.Commission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Commission.Width = 60;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "Name";
            this.ServerName.HeaderText = "服务人员";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServerName.Width = 70;
            // 
            // dtlOrderNo
            // 
            this.dtlOrderNo.DataPropertyName = "OrderNo";
            this.dtlOrderNo.HeaderText = "单号";
            this.dtlOrderNo.Name = "dtlOrderNo";
            this.dtlOrderNo.ReadOnly = true;
            this.dtlOrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtlOrderNo.Width = 70;
            // 
            // DtlCheckoutTime
            // 
            this.DtlCheckoutTime.DataPropertyName = "CheckoutTime";
            this.DtlCheckoutTime.HeaderText = "结帐时间";
            this.DtlCheckoutTime.Name = "DtlCheckoutTime";
            this.DtlCheckoutTime.ReadOnly = true;
            this.DtlCheckoutTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DtlCheckoutTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sale_Detail_ID
            // 
            this.Sale_Detail_ID.DataPropertyName = "Sale_Detail_ID";
            this.Sale_Detail_ID.HeaderText = "Sale_Detail_ID";
            this.Sale_Detail_ID.Name = "Sale_Detail_ID";
            this.Sale_Detail_ID.ReadOnly = true;
            this.Sale_Detail_ID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "共计金额：";
            // 
            // lbTotalAmountDtl
            // 
            this.lbTotalAmountDtl.AutoSize = true;
            this.lbTotalAmountDtl.Location = new System.Drawing.Point(79, 495);
            this.lbTotalAmountDtl.Name = "lbTotalAmountDtl";
            this.lbTotalAmountDtl.Size = new System.Drawing.Size(101, 12);
            this.lbTotalAmountDtl.TabIndex = 52;
            this.lbTotalAmountDtl.Text = "lbTotalAmountDtl";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 495);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 55;
            this.label11.Text = "提成：";
            // 
            // lbCommissionDtl
            // 
            this.lbCommissionDtl.AutoSize = true;
            this.lbCommissionDtl.Location = new System.Drawing.Point(260, 495);
            this.lbCommissionDtl.Name = "lbCommissionDtl";
            this.lbCommissionDtl.Size = new System.Drawing.Size(95, 12);
            this.lbCommissionDtl.TabIndex = 54;
            this.lbCommissionDtl.Text = "lbCommissionDtl";
            // 
            // ucPage1
            // 
            this.ucPage1.CurPage = 1;
            this.ucPage1.DataSetSql = "";
            this.ucPage1.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiOrder")));
            this.ucPage1.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiWhere")));
            this.ucPage1.Location = new System.Drawing.Point(6, 426);
            this.ucPage1.Name = "ucPage1";
            this.ucPage1.PageSize = 20;
            this.ucPage1.Size = new System.Drawing.Size(532, 27);
            this.ucPage1.TabIndex = 22;
            // 
            // ucPage2
            // 
            this.ucPage2.CurPage = 1;
            this.ucPage2.DataSetSql = "";
            this.ucPage2.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage2.LiOrder")));
            this.ucPage2.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage2.LiWhere")));
            this.ucPage2.Location = new System.Drawing.Point(10, 459);
            this.ucPage2.Name = "ucPage2";
            this.ucPage2.PageSize = 20;
            this.ucPage2.Size = new System.Drawing.Size(532, 27);
            this.ucPage2.TabIndex = 51;
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnShift);
            this.Name = "FormShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交班";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.UCPage ucPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMembershipCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUnionPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOther;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCommission;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxOrderNoDtl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbProName;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDtlSearch;
        private Controls.UCPage ucPage2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtlCheckoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Detail_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotalAmountDtl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCommissionDtl;
    }
}