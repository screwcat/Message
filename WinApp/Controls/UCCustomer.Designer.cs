namespace WinApp.Controls
{
    partial class UCCustomer
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbOperater = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSaleTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("MS PGothic", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.ForeColor = System.Drawing.Color.Red;
            this.lbCustomer.Location = new System.Drawing.Point(4, 3);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(138, 72);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.Text = "123";
            this.lbCustomer.Click += new System.EventHandler(this.lbCustomer_Click);
            this.lbCustomer.MouseLeave += new System.EventHandler(this.lbCustomer_MouseLeave);
            this.lbCustomer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbCustomer_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间号：";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Enabled = false;
            this.lbRoom.Location = new System.Drawing.Point(71, 81);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(23, 12);
            this.lbRoom.TabIndex = 2;
            this.lbRoom.Text = "123";
            // 
            // lbOperater
            // 
            this.lbOperater.AutoSize = true;
            this.lbOperater.Enabled = false;
            this.lbOperater.Location = new System.Drawing.Point(71, 98);
            this.lbOperater.Name = "lbOperater";
            this.lbOperater.Size = new System.Drawing.Size(23, 12);
            this.lbOperater.TabIndex = 4;
            this.lbOperater.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "操作员：";
            // 
            // lbSaleTime
            // 
            this.lbSaleTime.AutoSize = true;
            this.lbSaleTime.Enabled = false;
            this.lbSaleTime.Location = new System.Drawing.Point(14, 117);
            this.lbSaleTime.Name = "lbSaleTime";
            this.lbSaleTime.Size = new System.Drawing.Size(23, 12);
            this.lbSaleTime.TabIndex = 5;
            this.lbSaleTime.Text = "123";
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbSaleTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOperater);
            this.Controls.Add(this.lbRoom);
            this.Name = "UCCustomer";
            this.Size = new System.Drawing.Size(148, 148);
            this.Load += new System.EventHandler(this.UCCustomer_Load);
            this.Click += new System.EventHandler(this.UCCustomer_Click);
            this.MouseEnter += new System.EventHandler(this.UCCustomer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCCustomer_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbOperater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSaleTime;

    }
}
