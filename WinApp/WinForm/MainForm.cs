using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Threading;
using Message.Model;
using WinApp.Controls;
using WinApp.WinForm.Report;
using WinApp.WinForm.Admin;
using Service.Common;

namespace WinApp.WinForm
{
    public partial class MainForm : Form
    {
        const int AW_VER_NEGATIVE = 0x0008;
        const int AW_CENTER = 0x0010;
        const int AW_HIDE = 0x10000;

        Sale sale = new Sale();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            OpenSale(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                AnimateWindow(this.Handle, 1000, AW_CENTER | AW_HIDE | AW_VER_NEGATIVE);
                System.Environment.Exit(0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            DialogResult dr = frmLogin.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                AnimateWindow(this.Handle, 1000, AW_CENTER | AW_HIDE | AW_VER_NEGATIVE);
                System.Environment.Exit(0);
            }
        }
        private void BindListView()
        {
            flowLayoutPanel1.Controls.Clear();
            List<string[]> where = new List<string[]>();
            List<string[]> order = new List<string[]>();
            where.Add(new string[] { "State = {0}", "1" });
            order.Add(new string[] { "Customer", "ASC" });
            DataTable dt = sale.GetDataSet("SELECT * FROM Sale", where, order);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UCCustomer btn = new UCCustomer();
                btn.Text = dt.Rows[i]["Customer"].ToString();
                btn.SaleID = Convert.ToInt32(dt.Rows[i]["Sale_ID"].ToString());
                btn.CustemerNo = dt.Rows[i]["Customer"].ToString();
                btn.StoreHouse_ID = dt.Rows[i]["StoreHouse_ID"].ToString();
                btn.Employee_ID = dt.Rows[i]["Employee_ID"].ToString();
                btn.SaleDate = Convert.ToDateTime(dt.Rows[i]["SaleDate"]);
                btn.Margin = new Padding(8);
                btn.MyEvent += new EventEntrust(btn_MyEvent);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void btn_MyEvent(object sender, int e)
        {
            OpenSale(e);
        }

        private void OpenSale(Int32 SaleID)
        {
            FormSale fs1 = new FormSale(this, SaleID);
            fs1.Show();
            this.Hide();
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            BindListView();
            lbCurDate.Text = DateTime.Now.ToString("yyyy年M月d日 ") + DateTimeCommon.getWeek(Convert.ToInt32(DateTime.Now.DayOfWeek)) + " 农历：" + DateTimeCommon.GetChineseDate(DateTime.Now);
            Employee emp = new Employee();
            emp.FindbyPK(Thread.CurrentPrincipal.Identity.Name);
            lbCurUser.Text = emp.Name;
            timer1.Start();
            if (emp.Dept_ID != 0)
            {
                btnMaintain.Enabled = false;
                btnReportForm.Enabled = false;
            }
            else
            {
                btnMaintain.Enabled = true;
                btnReportForm.Enabled = true;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormSaleList fsl = new FormSaleList();
            fsl.ShowDialog();
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSetting fst = new FormSetting();
            fst.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
        }

        private void btnMembershipCard_Click(object sender, EventArgs e)
        {
            FormMembershipCard fmc = new FormMembershipCard();
            fmc.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("要开始备份数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                string strPath = Environment.CurrentDirectory + "\\Backup\\";
                FormDataBackup fdb = new FormDataBackup(strPath);
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("备份成功！");
                    System.Diagnostics.Process.Start("Explorer.exe", strPath);
                }
                else
                {
                    MessageBox.Show("备份失败！" + fdb.Rm.Message);
                }
            }
        }

        private void btnReLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("要退出当前帐号并重新登录吗？", "重新登录", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                FormLogin fl = new FormLogin();
                Hide();
                if (fl.ShowDialog() == DialogResult.OK)
                {
                    Show();
                }
            }
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.ShowDialog();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            FormShift fs = new FormShift(0);
            fs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test ts = new test();
            ts.ShowDialog();
        }

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
    }
}
