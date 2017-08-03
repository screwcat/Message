namespace WinApp.WinForm
{
    partial class FormSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTradeNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSaleDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.tbxStoreHouse_ID = new System.Windows.Forms.TextBox();
            this.btnCashier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnMergeBill = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOrderNo = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PaidIn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(725, 501);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(651, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(454, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(635, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "流水号：";
            // 
            // lbTradeNo
            // 
            this.lbTradeNo.AutoSize = true;
            this.lbTradeNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTradeNo.Location = new System.Drawing.Point(700, 137);
            this.lbTradeNo.Name = "lbTradeNo";
            this.lbTradeNo.Size = new System.Drawing.Size(0, 16);
            this.lbTradeNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(635, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "客户号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(635, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "房间号：";
            // 
            // lbSaleDate
            // 
            this.lbSaleDate.AutoSize = true;
            this.lbSaleDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSaleDate.Location = new System.Drawing.Point(700, 297);
            this.lbSaleDate.Name = "lbSaleDate";
            this.lbSaleDate.Size = new System.Drawing.Size(0, 12);
            this.lbSaleDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(635, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "时  间：";
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxCustomer.Location = new System.Drawing.Point(702, 213);
            this.tbxCustomer.MaxLength = 6;
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.Size = new System.Drawing.Size(100, 26);
            this.tbxCustomer.TabIndex = 0;
            this.tbxCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCustomer_KeyPress);
            this.tbxCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCustomer_KeyUp);
            // 
            // tbxStoreHouse_ID
            // 
            this.tbxStoreHouse_ID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxStoreHouse_ID.Location = new System.Drawing.Point(702, 254);
            this.tbxStoreHouse_ID.MaxLength = 6;
            this.tbxStoreHouse_ID.Name = "tbxStoreHouse_ID";
            this.tbxStoreHouse_ID.Size = new System.Drawing.Size(100, 26);
            this.tbxStoreHouse_ID.TabIndex = 1;
            this.tbxStoreHouse_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStoreHouse_ID_KeyPress);
            this.tbxStoreHouse_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxStoreHouse_ID_KeyUp);
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(535, 501);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(75, 23);
            this.btnCashier.TabIndex = 17;
            this.btnCashier.Text = "结帐";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(421, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "合计：";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(480, 448);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(36, 42);
            this.lbTotal.TabIndex = 19;
            this.lbTotal.Text = "0";
            // 
            // btnMergeBill
            // 
            this.btnMergeBill.Location = new System.Drawing.Point(616, 501);
            this.btnMergeBill.Name = "btnMergeBill";
            this.btnMergeBill.Size = new System.Drawing.Size(103, 23);
            this.btnMergeBill.TabIndex = 20;
            this.btnMergeBill.Text = "合并其他帐单";
            this.btnMergeBill.UseVisualStyleBackColor = true;
            this.btnMergeBill.Click += new System.EventHandler(this.btnMergeBill_Click);
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
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Discount,
            this.PaidIn1,
            this.PaidInAmount,
            this.ServerName});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 433);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(635, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "单  号：";
            // 
            // tbxOrderNo
            // 
            this.tbxOrderNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxOrderNo.Location = new System.Drawing.Point(702, 171);
            this.tbxOrderNo.MaxLength = 10;
            this.tbxOrderNo.Name = "tbxOrderNo";
            this.tbxOrderNo.Size = new System.Drawing.Size(100, 26);
            this.tbxOrderNo.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "ListNO";
            this.Code.HeaderText = "序号";
            this.Code.Name = "Code";
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Code.Width = 40;
            // 
            // ProCode
            // 
            this.ProCode.DataPropertyName = "Code";
            this.ProCode.HeaderText = "代码";
            this.ProCode.Name = "ProCode";
            this.ProCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProCode.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName1";
            this.ProductName.HeaderText = "名称";
            this.ProductName.Name = "ProductName";
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 50;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Discount.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.Width = 80;
            // 
            // PaidIn1
            // 
            this.PaidIn1.DataPropertyName = "PaidIn1";
            this.PaidIn1.HeaderText = "实收单价";
            this.PaidIn1.Name = "PaidIn1";
            this.PaidIn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PaidIn1.Width = 70;
            // 
            // PaidInAmount
            // 
            this.PaidInAmount.DataPropertyName = "PaidInAmount";
            this.PaidInAmount.HeaderText = "实收金额";
            this.PaidInAmount.Name = "PaidInAmount";
            this.PaidInAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PaidInAmount.Width = 70;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "Name";
            this.ServerName.HeaderText = "服务人员";
            this.ServerName.Name = "ServerName";
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServerName.Width = 80;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 536);
            this.Controls.Add(this.btnMergeBill);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.tbxStoreHouse_ID);
            this.Controls.Add(this.tbxOrderNo);
            this.Controls.Add(this.tbxCustomer);
            this.Controls.Add(this.lbSaleDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTradeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预结单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSale_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTradeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSaleDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.TextBox tbxStoreHouse_ID;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnMergeBill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidIn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
    }
}