namespace WinApp.WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbCurDate = new System.Windows.Forms.Label();
            this.btnMembershipCard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnReportForm = new System.Windows.Forms.Button();
            this.btnReLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(6, 20);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 23);
            this.btnBilling.TabIndex = 0;
            this.btnBilling.Text = "开单";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(6, 56);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(75, 23);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "营业记录";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnMaintain
            // 
            this.btnMaintain.Location = new System.Drawing.Point(7, 208);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(75, 23);
            this.btnMaintain.TabIndex = 2;
            this.btnMaintain.Text = "管理";
            this.btnMaintain.UseVisualStyleBackColor = true;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(7, 170);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "数据备份";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(677, 418);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(113, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 439);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前顾客";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(7, 130);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "欢迎使用";
            // 
            // lbCurUser
            // 
            this.lbCurUser.AutoSize = true;
            this.lbCurUser.Location = new System.Drawing.Point(84, 453);
            this.lbCurUser.Name = "lbCurUser";
            this.lbCurUser.Size = new System.Drawing.Size(23, 12);
            this.lbCurUser.TabIndex = 7;
            this.lbCurUser.Text = "{0}";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "当前时间：";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(588, 453);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(23, 12);
            this.lbCurrentTime.TabIndex = 7;
            this.lbCurrentTime.Text = "{2}";
            // 
            // lbCurDate
            // 
            this.lbCurDate.AutoSize = true;
            this.lbCurDate.Location = new System.Drawing.Point(253, 453);
            this.lbCurDate.Name = "lbCurDate";
            this.lbCurDate.Size = new System.Drawing.Size(23, 12);
            this.lbCurDate.TabIndex = 7;
            this.lbCurDate.Text = "{1}";
            // 
            // btnMembershipCard
            // 
            this.btnMembershipCard.Location = new System.Drawing.Point(7, 95);
            this.btnMembershipCard.Name = "btnMembershipCard";
            this.btnMembershipCard.Size = new System.Drawing.Size(75, 23);
            this.btnMembershipCard.TabIndex = 3;
            this.btnMembershipCard.Text = "会员卡";
            this.btnMembershipCard.UseVisualStyleBackColor = true;
            this.btnMembershipCard.Click += new System.EventHandler(this.btnMembershipCard_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShift);
            this.groupBox2.Controls.Add(this.btnMaintain);
            this.groupBox2.Controls.Add(this.btnMembershipCard);
            this.groupBox2.Controls.Add(this.btnBilling);
            this.groupBox2.Controls.Add(this.btnStatistics);
            this.groupBox2.Controls.Add(this.btnBackup);
            this.groupBox2.Controls.Add(this.btnReportForm);
            this.groupBox2.Controls.Add(this.btnReLogin);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnSetting);
            this.groupBox2.Location = new System.Drawing.Point(11, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 395);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(6, 281);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(75, 23);
            this.btnShift.TabIndex = 4;
            this.btnShift.Text = "交班";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnReportForm
            // 
            this.btnReportForm.Location = new System.Drawing.Point(7, 244);
            this.btnReportForm.Name = "btnReportForm";
            this.btnReportForm.Size = new System.Drawing.Size(75, 23);
            this.btnReportForm.TabIndex = 3;
            this.btnReportForm.Text = "报表";
            this.btnReportForm.UseVisualStyleBackColor = true;
            this.btnReportForm.Click += new System.EventHandler(this.btnReportForm_Click);
            // 
            // btnReLogin
            // 
            this.btnReLogin.Location = new System.Drawing.Point(6, 315);
            this.btnReLogin.Name = "btnReLogin";
            this.btnReLogin.Size = new System.Drawing.Size(75, 23);
            this.btnReLogin.TabIndex = 3;
            this.btnReLogin.Text = "重新登录";
            this.btnReLogin.UseVisualStyleBackColor = true;
            this.btnReLogin.Click += new System.EventHandler(this.btnReLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbCurUser);
            this.Controls.Add(this.lbCurrentTime);
            this.Controls.Add(this.lbCurDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "康桥足道会馆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCurUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label lbCurDate;
        private System.Windows.Forms.Button btnMembershipCard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReportForm;
        private System.Windows.Forms.Button btnReLogin;
        private System.Windows.Forms.Button btnShift;
    }
}