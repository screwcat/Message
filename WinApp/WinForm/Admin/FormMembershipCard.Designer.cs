namespace WinApp.WinForm.Admin
{
    partial class FormMembershipCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMembershipCard));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCardNo = new System.Windows.Forms.TextBox();
            this.btnHandleCard = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPage1 = new WinApp.Controls.UCPage();
            this.tbxMemName = new System.Windows.Forms.TextBox();
            this.tbxMemTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入卡号：";
            // 
            // tbxCardNo
            // 
            this.tbxCardNo.Location = new System.Drawing.Point(85, 22);
            this.tbxCardNo.Name = "tbxCardNo";
            this.tbxCardNo.Size = new System.Drawing.Size(125, 21);
            this.tbxCardNo.TabIndex = 0;
            // 
            // btnHandleCard
            // 
            this.btnHandleCard.Location = new System.Drawing.Point(602, 20);
            this.btnHandleCard.Name = "btnHandleCard";
            this.btnHandleCard.Size = new System.Drawing.Size(75, 23);
            this.btnHandleCard.TabIndex = 2;
            this.btnHandleCard.Text = "办卡";
            this.btnHandleCard.UseVisualStyleBackColor = true;
            this.btnHandleCard.Click += new System.EventHandler(this.btnHandleCard_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(602, 457);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "返回";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(516, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.CardNO,
            this.TypeName,
            this.MemberName,
            this.UserTel,
            this.HandleTime,
            this.Balance,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(14, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 392);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            // CardNO
            // 
            this.CardNO.DataPropertyName = "CardNO";
            this.CardNO.HeaderText = "卡号";
            this.CardNO.Name = "CardNO";
            this.CardNO.ReadOnly = true;
            this.CardNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类型";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeName.Width = 90;
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "MemberName";
            this.MemberName.HeaderText = "姓名";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MemberName.Width = 70;
            // 
            // UserTel
            // 
            this.UserTel.DataPropertyName = "UserTel";
            this.UserTel.HeaderText = "电话";
            this.UserTel.Name = "UserTel";
            this.UserTel.ReadOnly = true;
            this.UserTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserTel.Width = 80;
            // 
            // HandleTime
            // 
            this.HandleTime.DataPropertyName = "HandleTime";
            this.HandleTime.HeaderText = "办卡时间";
            this.HandleTime.Name = "HandleTime";
            this.HandleTime.ReadOnly = true;
            this.HandleTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HandleTime.Width = 130;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "余额";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Balance.Width = 120;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ucPage1
            // 
            this.ucPage1.CurPage = 1;
            this.ucPage1.DataSetSql = "";
            this.ucPage1.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiOrder")));
            this.ucPage1.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiWhere")));
            this.ucPage1.Location = new System.Drawing.Point(12, 457);
            this.ucPage1.Name = "ucPage1";
            this.ucPage1.PageSize = 20;
            this.ucPage1.Size = new System.Drawing.Size(532, 27);
            this.ucPage1.TabIndex = 5;
            // 
            // tbxMemName
            // 
            this.tbxMemName.Location = new System.Drawing.Point(255, 22);
            this.tbxMemName.Name = "tbxMemName";
            this.tbxMemName.Size = new System.Drawing.Size(102, 21);
            this.tbxMemName.TabIndex = 1;
            // 
            // tbxMemTel
            // 
            this.tbxMemTel.Location = new System.Drawing.Point(393, 22);
            this.tbxMemTel.Name = "tbxMemTel";
            this.tbxMemTel.Size = new System.Drawing.Size(102, 21);
            this.tbxMemTel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "电话：";
            // 
            // FormMembershipCard
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 496);
            this.Controls.Add(this.ucPage1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnHandleCard);
            this.Controls.Add(this.tbxMemTel);
            this.Controls.Add(this.tbxMemName);
            this.Controls.Add(this.tbxCardNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMembershipCard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员卡管理";
            this.Load += new System.EventHandler(this.FormMembershipCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCardNo;
        private System.Windows.Forms.Button btnHandleCard;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.UCPage ucPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox tbxMemName;
        private System.Windows.Forms.TextBox tbxMemTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}