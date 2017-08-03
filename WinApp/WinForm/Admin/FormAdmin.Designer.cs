namespace WinApp.WinForm.Admin
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxPinYin = new System.Windows.Forms.TextBox();
            this.tbxProName = new System.Windows.Forms.TextBox();
            this.tbxProCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAvailable = new System.Windows.Forms.RadioButton();
            this.rbNotAvailable = new System.Windows.Forms.RadioButton();
            this.tbxDiscountRate = new System.Windows.Forms.TextBox();
            this.tbxDisName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.btnCreateType = new System.Windows.Forms.Button();
            this.btnSaveCardType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbctAvailable = new System.Windows.Forms.RadioButton();
            this.rbctNotAvailable = new System.Windows.Forms.RadioButton();
            this.tbxCardTypeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCardType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardTypeDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPage1 = new WinApp.Controls.UCPage();
            this.ucPage2 = new WinApp.Controls.UCPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardType)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewUser);
            this.tabPage1.Controls.Add(this.ucPage1);
            this.tabPage1.Controls.Add(this.dgvEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人员管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(18, 468);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnNewUser.TabIndex = 9;
            this.btnNewUser.Text = "新建用户";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Employee_ID,
            this.UserName,
            this.empName,
            this.Gender,
            this.Duty,
            this.Customer});
            this.dgvEmployee.Location = new System.Drawing.Point(6, 6);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowTemplate.Height = 23;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(637, 450);
            this.dgvEmployee.TabIndex = 7;
            this.dgvEmployee.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "Employee_ID";
            this.Employee_ID.HeaderText = "编号";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            this.Employee_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "登录名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserName.Width = 150;
            // 
            // empName
            // 
            this.empName.DataPropertyName = "Name";
            this.empName.HeaderText = "姓名";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.empName.Width = 110;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // Duty
            // 
            this.Duty.DataPropertyName = "Duty";
            this.Duty.HeaderText = "职责";
            this.Duty.Name = "Duty";
            this.Duty.ReadOnly = true;
            this.Duty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Duty.Width = 80;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Phone";
            this.Customer.HeaderText = "电话";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Customer.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.tbxPinYin);
            this.tabPage2.Controls.Add(this.tbxProName);
            this.tabPage2.Controls.Add(this.tbxProCode);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgvProduct);
            this.tabPage2.Controls.Add(this.ucPage2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "商品管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(566, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxPinYin
            // 
            this.tbxPinYin.Location = new System.Drawing.Point(431, 7);
            this.tbxPinYin.Name = "tbxPinYin";
            this.tbxPinYin.Size = new System.Drawing.Size(132, 21);
            this.tbxPinYin.TabIndex = 12;
            // 
            // tbxProName
            // 
            this.tbxProName.Location = new System.Drawing.Point(250, 7);
            this.tbxProName.Name = "tbxProName";
            this.tbxProName.Size = new System.Drawing.Size(132, 21);
            this.tbxProName.TabIndex = 12;
            // 
            // tbxProCode
            // 
            this.tbxProCode.Location = new System.Drawing.Point(58, 7);
            this.tbxProCode.Name = "tbxProCode";
            this.tbxProCode.Size = new System.Drawing.Size(132, 21);
            this.tbxProCode.TabIndex = 12;
            this.tbxProCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProCode_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "拼音：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "商品名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "商品号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "新建商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.proCode,
            this.proName,
            this.spell,
            this.Price,
            this.Commission,
            this.CreateDate,
            this.Product_ID});
            this.dgvProduct.Location = new System.Drawing.Point(6, 34);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowTemplate.Height = 23;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(637, 424);
            this.dgvProduct.TabIndex = 8;
            this.dgvProduct.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_CellMouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddDiscount);
            this.tabPage3.Controls.Add(this.btnSaveDiscount);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.tbxDiscountRate);
            this.tabPage3.Controls.Add(this.tbxDisName);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dgvDiscount);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "折扣管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(441, 190);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnAddDiscount.TabIndex = 4;
            this.btnAddDiscount.Text = "添加";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnSaveDiscount
            // 
            this.btnSaveDiscount.Location = new System.Drawing.Point(532, 190);
            this.btnSaveDiscount.Name = "btnSaveDiscount";
            this.btnSaveDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDiscount.TabIndex = 5;
            this.btnSaveDiscount.Text = "保存";
            this.btnSaveDiscount.UseVisualStyleBackColor = true;
            this.btnSaveDiscount.Click += new System.EventHandler(this.btnSaveDiscount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAvailable);
            this.groupBox1.Controls.Add(this.rbNotAvailable);
            this.groupBox1.Location = new System.Drawing.Point(441, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 29);
            this.groupBox1.TabIndex = 12;
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
            this.tbxDiscountRate.Location = new System.Drawing.Point(451, 90);
            this.tbxDiscountRate.Name = "tbxDiscountRate";
            this.tbxDiscountRate.Size = new System.Drawing.Size(121, 21);
            this.tbxDiscountRate.TabIndex = 1;
            this.tbxDiscountRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscountRate_KeyPress);
            // 
            // tbxDisName
            // 
            this.tbxDisName.Location = new System.Drawing.Point(451, 60);
            this.tbxDisName.Name = "tbxDisName";
            this.tbxDisName.Size = new System.Drawing.Size(121, 21);
            this.tbxDisName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "折扣：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "名称：";
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.AllowUserToResizeColumns = false;
            this.dgvDiscount.AllowUserToResizeRows = false;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.DisName,
            this.DiscountRate,
            this.Available,
            this.DiscountID});
            this.dgvDiscount.Location = new System.Drawing.Point(12, 25);
            this.dgvDiscount.MultiSelect = false;
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.RowHeadersVisible = false;
            this.dgvDiscount.RowTemplate.Height = 23;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(375, 450);
            this.dgvDiscount.TabIndex = 9;
            this.dgvDiscount.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDiscount_RowPostPaint);
            this.dgvDiscount.SelectionChanged += new System.EventHandler(this.dgvDiscount_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MB";
            this.dataGridViewTextBoxColumn2.HeaderText = "序号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // DisName
            // 
            this.DisName.DataPropertyName = "DisName";
            this.DisName.HeaderText = "名称";
            this.DisName.Name = "DisName";
            this.DisName.ReadOnly = true;
            this.DisName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DisName.Width = 120;
            // 
            // DiscountRate
            // 
            this.DiscountRate.DataPropertyName = "DiscountRate";
            this.DiscountRate.HeaderText = "折扣";
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.ReadOnly = true;
            this.DiscountRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DiscountRate.Width = 120;
            // 
            // Available
            // 
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "是否可用";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            this.Available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Available.Width = 80;
            // 
            // DiscountID
            // 
            this.DiscountID.DataPropertyName = "ID";
            this.DiscountID.HeaderText = "DiscountID";
            this.DiscountID.Name = "DiscountID";
            this.DiscountID.ReadOnly = true;
            this.DiscountID.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbDiscount);
            this.tabPage4.Controls.Add(this.btnCreateType);
            this.tabPage4.Controls.Add(this.btnSaveCardType);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.tbxCardTypeName);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dgvCardType);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(649, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "会员卡种类管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // cbDiscount
            // 
            this.cbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(451, 90);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(121, 20);
            this.cbDiscount.TabIndex = 21;
            // 
            // btnCreateType
            // 
            this.btnCreateType.Location = new System.Drawing.Point(441, 190);
            this.btnCreateType.Name = "btnCreateType";
            this.btnCreateType.Size = new System.Drawing.Size(75, 23);
            this.btnCreateType.TabIndex = 15;
            this.btnCreateType.Text = "添加";
            this.btnCreateType.UseVisualStyleBackColor = true;
            this.btnCreateType.Click += new System.EventHandler(this.btnCreateType_Click);
            // 
            // btnSaveCardType
            // 
            this.btnSaveCardType.Location = new System.Drawing.Point(532, 190);
            this.btnSaveCardType.Name = "btnSaveCardType";
            this.btnSaveCardType.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCardType.TabIndex = 16;
            this.btnSaveCardType.Text = "保存";
            this.btnSaveCardType.UseVisualStyleBackColor = true;
            this.btnSaveCardType.Click += new System.EventHandler(this.btnSaveCardType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbctAvailable);
            this.groupBox2.Controls.Add(this.rbctNotAvailable);
            this.groupBox2.Location = new System.Drawing.Point(441, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 29);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // rbctAvailable
            // 
            this.rbctAvailable.AutoSize = true;
            this.rbctAvailable.Checked = true;
            this.rbctAvailable.Location = new System.Drawing.Point(4, 10);
            this.rbctAvailable.Name = "rbctAvailable";
            this.rbctAvailable.Size = new System.Drawing.Size(47, 16);
            this.rbctAvailable.TabIndex = 2;
            this.rbctAvailable.TabStop = true;
            this.rbctAvailable.Text = "可用";
            this.rbctAvailable.UseVisualStyleBackColor = true;
            // 
            // rbctNotAvailable
            // 
            this.rbctNotAvailable.AutoSize = true;
            this.rbctNotAvailable.Location = new System.Drawing.Point(58, 10);
            this.rbctNotAvailable.Name = "rbctNotAvailable";
            this.rbctNotAvailable.Size = new System.Drawing.Size(59, 16);
            this.rbctNotAvailable.TabIndex = 3;
            this.rbctNotAvailable.Text = "不可用";
            this.rbctNotAvailable.UseVisualStyleBackColor = true;
            // 
            // tbxCardTypeName
            // 
            this.tbxCardTypeName.Location = new System.Drawing.Point(451, 60);
            this.tbxCardTypeName.Name = "tbxCardTypeName";
            this.tbxCardTypeName.Size = new System.Drawing.Size(121, 21);
            this.tbxCardTypeName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "折扣：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "名称：";
            // 
            // dgvCardType
            // 
            this.dgvCardType.AllowUserToAddRows = false;
            this.dgvCardType.AllowUserToDeleteRows = false;
            this.dgvCardType.AllowUserToResizeColumns = false;
            this.dgvCardType.AllowUserToResizeRows = false;
            this.dgvCardType.BackgroundColor = System.Drawing.Color.White;
            this.dgvCardType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.TypeName,
            this.CardTypeDiscount,
            this.CardAvailable,
            this.CardTypeID});
            this.dgvCardType.Location = new System.Drawing.Point(12, 25);
            this.dgvCardType.MultiSelect = false;
            this.dgvCardType.Name = "dgvCardType";
            this.dgvCardType.ReadOnly = true;
            this.dgvCardType.RowHeadersVisible = false;
            this.dgvCardType.RowTemplate.Height = 23;
            this.dgvCardType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardType.Size = new System.Drawing.Size(375, 450);
            this.dgvCardType.TabIndex = 17;
            this.dgvCardType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCardType_RowPostPaint);
            this.dgvCardType.SelectionChanged += new System.EventHandler(this.dgvCardType_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MB";
            this.dataGridViewTextBoxColumn3.HeaderText = "序号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "卡名称";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeName.Width = 120;
            // 
            // CardTypeDiscount
            // 
            this.CardTypeDiscount.DataPropertyName = "Discount";
            this.CardTypeDiscount.HeaderText = "折扣";
            this.CardTypeDiscount.Name = "CardTypeDiscount";
            this.CardTypeDiscount.ReadOnly = true;
            this.CardTypeDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CardTypeDiscount.Width = 120;
            // 
            // CardAvailable
            // 
            this.CardAvailable.DataPropertyName = "Available";
            this.CardAvailable.HeaderText = "是否可用";
            this.CardAvailable.Name = "CardAvailable";
            this.CardAvailable.ReadOnly = true;
            this.CardAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CardAvailable.Width = 80;
            // 
            // CardTypeID
            // 
            this.CardTypeID.DataPropertyName = "ID";
            this.CardTypeID.HeaderText = "CardTypeID";
            this.CardTypeID.Name = "CardTypeID";
            this.CardTypeID.ReadOnly = true;
            this.CardTypeID.Visible = false;
            // 
            // ucPage1
            // 
            this.ucPage1.CurPage = 1;
            this.ucPage1.DataSetSql = "";
            this.ucPage1.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiOrder")));
            this.ucPage1.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiWhere")));
            this.ucPage1.Location = new System.Drawing.Point(111, 468);
            this.ucPage1.Name = "ucPage1";
            this.ucPage1.PageSize = 20;
            this.ucPage1.Size = new System.Drawing.Size(532, 27);
            this.ucPage1.TabIndex = 8;
            // 
            // ucPage2
            // 
            this.ucPage2.CurPage = 1;
            this.ucPage2.DataSetSql = "";
            this.ucPage2.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage2.LiOrder")));
            this.ucPage2.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage2.LiWhere")));
            this.ucPage2.Location = new System.Drawing.Point(111, 468);
            this.ucPage2.Name = "ucPage2";
            this.ucPage2.PageSize = 20;
            this.ucPage2.Size = new System.Drawing.Size(532, 27);
            this.ucPage2.TabIndex = 9;
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
            // proCode
            // 
            this.proCode.DataPropertyName = "Code";
            this.proCode.HeaderText = "编号";
            this.proCode.Name = "proCode";
            this.proCode.ReadOnly = true;
            this.proCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proCode.Width = 60;
            // 
            // proName
            // 
            this.proName.DataPropertyName = "Name";
            this.proName.HeaderText = "名称";
            this.proName.Name = "proName";
            this.proName.ReadOnly = true;
            this.proName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proName.Width = 150;
            // 
            // spell
            // 
            this.spell.DataPropertyName = "spell";
            this.spell.HeaderText = "拼音";
            this.spell.Name = "spell";
            this.spell.ReadOnly = true;
            this.spell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.spell.Width = 70;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // Commission
            // 
            this.Commission.DataPropertyName = "Commission";
            this.Commission.HeaderText = "提成";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            this.Commission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Commission.Width = 80;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "添加时间";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreateDate.Width = 120;
            // 
            // Product_ID
            // 
            this.Product_ID.DataPropertyName = "Product_ID";
            this.Product_ID.HeaderText = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            this.Product_ID.Visible = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 546);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统管理";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private Controls.UCPage ucPage1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridView dgvProduct;
        private Controls.UCPage ucPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.TextBox tbxDiscountRate;
        private System.Windows.Forms.TextBox tbxDisName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.RadioButton rbNotAvailable;
        private System.Windows.Forms.Button btnSaveDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCreateType;
        private System.Windows.Forms.Button btnSaveCardType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbctAvailable;
        private System.Windows.Forms.RadioButton rbctNotAvailable;
        private System.Windows.Forms.TextBox tbxCardTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardTypeDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardTypeID;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxPinYin;
        private System.Windows.Forms.TextBox tbxProName;
        private System.Windows.Forms.TextBox tbxProCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn spell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
    }
}