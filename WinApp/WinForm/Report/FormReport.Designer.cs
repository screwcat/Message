namespace WinApp.WinForm.Report
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updgvSummary = new WinApp.Controls.UCPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOrderNo = new System.Windows.Forms.TextBox();
            this.tbxTradCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreHouse_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxOrderNoDtl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxDtlTradCode = new System.Windows.Forms.TextBox();
            this.lbCommission = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProName = new System.Windows.Forms.ComboBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.btnDtlExport = new System.Windows.Forms.Button();
            this.lbDtlTotalAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updgvDetail = new WinApp.Controls.UCPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDtlSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDtlTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDtlFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtlTradeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtlCheckoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Detail_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExport);
            this.tabPage1.Controls.Add(this.lbTotalAmount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.updgvSummary);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbxOrderNo);
            this.tabPage1.Controls.Add(this.tbxTradCode);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpTo);
            this.tabPage1.Controls.Add(this.dtpFrom);
            this.tabPage1.Controls.Add(this.dgvSummary);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "汇总表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(836, 518);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(73, 23);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "导出Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lbTotalAmount.Location = new System.Drawing.Point(637, 516);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(130, 22);
            this.lbTotalAmount.TabIndex = 22;
            this.lbTotalAmount.Text = "lbTotalAmount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "总金额：";
            // 
            // updgvSummary
            // 
            this.updgvSummary.CurPage = 1;
            this.updgvSummary.DataSetSql = "";
            this.updgvSummary.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("updgvSummary.LiOrder")));
            this.updgvSummary.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("updgvSummary.LiWhere")));
            this.updgvSummary.Location = new System.Drawing.Point(13, 514);
            this.updgvSummary.Name = "updgvSummary";
            this.updgvSummary.PageSize = 20;
            this.updgvSummary.Size = new System.Drawing.Size(532, 27);
            this.updgvSummary.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "单号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "流水号：";
            // 
            // tbxOrderNo
            // 
            this.tbxOrderNo.Location = new System.Drawing.Point(246, 48);
            this.tbxOrderNo.Name = "tbxOrderNo";
            this.tbxOrderNo.Size = new System.Drawing.Size(122, 21);
            this.tbxOrderNo.TabIndex = 19;
            // 
            // tbxTradCode
            // 
            this.tbxTradCode.Location = new System.Drawing.Point(65, 48);
            this.tbxTradCode.Name = "tbxTradCode";
            this.tbxTradCode.Size = new System.Drawing.Size(122, 21);
            this.tbxTradCode.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "~";
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.Location = new System.Drawing.Point(205, 13);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.Size = new System.Drawing.Size(122, 21);
            this.dtpTo.TabIndex = 15;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Location = new System.Drawing.Point(65, 13);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Size = new System.Drawing.Size(122, 21);
            this.dtpFrom.TabIndex = 14;
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.AllowUserToResizeColumns = false;
            this.dgvSummary.AllowUserToResizeRows = false;
            this.dgvSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.TradeNo,
            this.OrderNo,
            this.SaleDate,
            this.CheckoutTime,
            this.TotalAmount,
            this.Customer,
            this.StoreHouse_ID,
            this.OptName,
            this.Sale_ID});
            this.dgvSummary.Location = new System.Drawing.Point(13, 81);
            this.dgvSummary.MultiSelect = false;
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.RowTemplate.Height = 23;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.Size = new System.Drawing.Size(900, 425);
            this.dgvSummary.TabIndex = 13;
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
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "开单时间";
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            this.SaleDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaleDate.Width = 150;
            // 
            // CheckoutTime
            // 
            this.CheckoutTime.DataPropertyName = "CheckoutTime";
            this.CheckoutTime.HeaderText = "结帐时间";
            this.CheckoutTime.Name = "CheckoutTime";
            this.CheckoutTime.ReadOnly = true;
            this.CheckoutTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CheckoutTime.Width = 150;
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
            // StoreHouse_ID
            // 
            this.StoreHouse_ID.DataPropertyName = "StoreHouse_ID";
            this.StoreHouse_ID.HeaderText = "房间号";
            this.StoreHouse_ID.Name = "StoreHouse_ID";
            this.StoreHouse_ID.ReadOnly = true;
            this.StoreHouse_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StoreHouse_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxOrderNoDtl);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbxDtlTradCode);
            this.tabPage2.Controls.Add(this.lbCommission);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cbProName);
            this.tabPage2.Controls.Add(this.cbServer);
            this.tabPage2.Controls.Add(this.btnDtlExport);
            this.tabPage2.Controls.Add(this.lbDtlTotalAmount);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.updgvDetail);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnDtlSearch);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtpDtlTo);
            this.tabPage2.Controls.Add(this.dtpDtlFrom);
            this.tabPage2.Controls.Add(this.dgvDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "明细表";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // tbxOrderNoDtl
            // 
            this.tbxOrderNoDtl.Location = new System.Drawing.Point(440, 48);
            this.tbxOrderNoDtl.Name = "tbxOrderNoDtl";
            this.tbxOrderNoDtl.Size = new System.Drawing.Size(122, 21);
            this.tbxOrderNoDtl.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "单号：";
            // 
            // tbxDtlTradCode
            // 
            this.tbxDtlTradCode.Location = new System.Drawing.Point(439, 13);
            this.tbxDtlTradCode.Name = "tbxDtlTradCode";
            this.tbxDtlTradCode.Size = new System.Drawing.Size(122, 21);
            this.tbxDtlTradCode.TabIndex = 40;
            // 
            // lbCommission
            // 
            this.lbCommission.AutoSize = true;
            this.lbCommission.Location = new System.Drawing.Point(770, 522);
            this.lbCommission.Name = "lbCommission";
            this.lbCommission.Size = new System.Drawing.Size(77, 12);
            this.lbCommission.TabIndex = 39;
            this.lbCommission.Text = "lbCommission";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(737, 522);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "提成：";
            // 
            // cbProName
            // 
            this.cbProName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProName.FormattingEnabled = true;
            this.cbProName.Location = new System.Drawing.Point(76, 51);
            this.cbProName.Name = "cbProName";
            this.cbProName.Size = new System.Drawing.Size(121, 20);
            this.cbProName.TabIndex = 37;
            // 
            // cbServer
            // 
            this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(279, 50);
            this.cbServer.MaxDropDownItems = 100;
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(107, 20);
            this.cbServer.TabIndex = 36;
            // 
            // btnDtlExport
            // 
            this.btnDtlExport.Location = new System.Drawing.Point(854, 516);
            this.btnDtlExport.Name = "btnDtlExport";
            this.btnDtlExport.Size = new System.Drawing.Size(73, 23);
            this.btnDtlExport.TabIndex = 35;
            this.btnDtlExport.Text = "导出Excel";
            this.btnDtlExport.UseVisualStyleBackColor = true;
            this.btnDtlExport.Click += new System.EventHandler(this.btnDtlExport_Click);
            // 
            // lbDtlTotalAmount
            // 
            this.lbDtlTotalAmount.AutoSize = true;
            this.lbDtlTotalAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDtlTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lbDtlTotalAmount.Location = new System.Drawing.Point(585, 516);
            this.lbDtlTotalAmount.Name = "lbDtlTotalAmount";
            this.lbDtlTotalAmount.Size = new System.Drawing.Size(153, 22);
            this.lbDtlTotalAmount.TabIndex = 33;
            this.lbDtlTotalAmount.Text = "lbDtlTotalAmount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "总金额：";
            // 
            // updgvDetail
            // 
            this.updgvDetail.CurPage = 1;
            this.updgvDetail.DataSetSql = "";
            this.updgvDetail.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("updgvDetail.LiOrder")));
            this.updgvDetail.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("updgvDetail.LiWhere")));
            this.updgvDetail.Location = new System.Drawing.Point(9, 514);
            this.updgvDetail.Name = "updgvDetail";
            this.updgvDetail.PageSize = 20;
            this.updgvDetail.Size = new System.Drawing.Size(532, 27);
            this.updgvDetail.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "服务人员：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "品名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "流水号：";
            // 
            // btnDtlSearch
            // 
            this.btnDtlSearch.Location = new System.Drawing.Point(605, 48);
            this.btnDtlSearch.Name = "btnDtlSearch";
            this.btnDtlSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDtlSearch.TabIndex = 29;
            this.btnDtlSearch.Text = "查找";
            this.btnDtlSearch.UseVisualStyleBackColor = true;
            this.btnDtlSearch.Click += new System.EventHandler(this.btnDtlSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "结帐时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "~";
            // 
            // dtpDtlTo
            // 
            this.dtpDtlTo.Checked = false;
            this.dtpDtlTo.Location = new System.Drawing.Point(216, 13);
            this.dtpDtlTo.Name = "dtpDtlTo";
            this.dtpDtlTo.ShowCheckBox = true;
            this.dtpDtlTo.Size = new System.Drawing.Size(122, 21);
            this.dtpDtlTo.TabIndex = 26;
            // 
            // dtpDtlFrom
            // 
            this.dtpDtlFrom.Checked = false;
            this.dtpDtlFrom.Location = new System.Drawing.Point(76, 13);
            this.dtpDtlFrom.Name = "dtpDtlFrom";
            this.dtpDtlFrom.ShowCheckBox = true;
            this.dtpDtlFrom.Size = new System.Drawing.Size(122, 21);
            this.dtpDtlFrom.TabIndex = 25;
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
            this.Discount,
            this.Total,
            this.Commission,
            this.ServerName,
            this.DtlTradeNo,
            this.dtlOrderNo,
            this.DtlCheckoutTime,
            this.Sale_Detail_ID});
            this.dgvDetail.Location = new System.Drawing.Point(13, 81);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(908, 425);
            this.dgvDetail.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MB";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "品名";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Quantity.Width = 50;
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
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "实收金额";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 90;
            // 
            // Commission
            // 
            this.Commission.DataPropertyName = "Commission";
            this.Commission.HeaderText = "提成";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            this.Commission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Commission.Width = 70;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "Name";
            this.ServerName.HeaderText = "服务人员";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServerName.Width = 80;
            // 
            // DtlTradeNo
            // 
            this.DtlTradeNo.DataPropertyName = "TradeNo";
            this.DtlTradeNo.HeaderText = "流水号";
            this.DtlTradeNo.Name = "DtlTradeNo";
            this.DtlTradeNo.ReadOnly = true;
            this.DtlTradeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtlOrderNo
            // 
            this.dtlOrderNo.DataPropertyName = "OrderNo";
            this.dtlOrderNo.HeaderText = "单号";
            this.dtlOrderNo.Name = "dtlOrderNo";
            this.dtlOrderNo.ReadOnly = true;
            this.dtlOrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DtlCheckoutTime
            // 
            this.DtlCheckoutTime.DataPropertyName = "CheckoutTime";
            this.DtlCheckoutTime.HeaderText = "结帐时间";
            this.DtlCheckoutTime.Name = "DtlCheckoutTime";
            this.DtlCheckoutTime.ReadOnly = true;
            this.DtlCheckoutTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DtlCheckoutTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DtlCheckoutTime.Width = 120;
            // 
            // Sale_Detail_ID
            // 
            this.Sale_Detail_ID.DataPropertyName = "Sale_Detail_ID";
            this.Sale_Detail_ID.HeaderText = "Sale_Detail_ID";
            this.Sale_Detail_ID.Name = "Sale_Detail_ID";
            this.Sale_Detail_ID.ReadOnly = true;
            this.Sale_Detail_ID.Visible = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 593);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报表";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTradCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridView dgvSummary;
        private Controls.UCPage updgvSummary;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDtlExport;
        private System.Windows.Forms.Label lbDtlTotalAmount;
        private System.Windows.Forms.Label label6;
        private Controls.UCPage updgvDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDtlSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDtlTo;
        private System.Windows.Forms.DateTimePicker dtpDtlFrom;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreHouse_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_ID;
        private System.Windows.Forms.Label lbCommission;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtlTradeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtlCheckoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Detail_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxOrderNo;
        private System.Windows.Forms.TextBox tbxOrderNoDtl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxDtlTradCode;
    }
}