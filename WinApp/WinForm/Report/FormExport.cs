using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Message.Model;
using Service.Common;
using WinApp.Controls;

namespace WinApp.WinForm.Report
{
    public partial class FormExport : Form
    {
        Sale SaleInfo = new Sale();
        Sale_Detail sdInfo = new Sale_Detail();
        UCPage ucpage = new UCPage();
        public FormExport(UCPage UCPage)
        {
            Control.CheckForIllegalCrossThreadCalls = false; 
            InitializeComponent();
            ee.ExportEvent += new ExcelExportEntrust(ee_ExportEvent);
            ExportSummary(UCPage);
        }
        ExcelExport ee = new ExcelExport();
        private void ExportSummary(UCPage ucPage)
        {
            ucpage = ucPage;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                Close();
            }
        }

        void ee_ExportEvent(int Schedule)
        {
            backgroundWorker1.ReportProgress(Schedule);
            progressBar1.Value = Schedule;
            lbSchedule.Text = "正在导出，已完成 " + Schedule + "%。。。。。。";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt = SaleInfo.GetDataSet(ucpage.DataSetSql, ucpage.LiWhere, ucpage.LiOrder);
            if (dt.Rows.Count > 65000)
            {
                MessageBox.Show("汇总统计表的行数已经超过Excel文件的容量（65536行），不能导出，请缩小统计范围！");
                return;
            }
            ds.Tables.Add(dt.Copy());

            Employee emp = new Employee();
            emp.FindbyPK(Thread.CurrentPrincipal.Identity.Name);
            string PeriodTime = "";

            List<string[]> liWhere = ucpage.LiWhere;
            for (int i = 0; i < liWhere.Count; i++)
            {
                if (liWhere[i][0] == "CheckoutTime > {0}")
                {
                    PeriodTime += Convert.ToDateTime(liWhere[i][1]).ToString("yyyy-M-d") + "～";
                }
                if (liWhere[i][0] == "CheckoutTime < {0}")
                {
                    PeriodTime += Convert.ToDateTime(liWhere[i][1]).AddDays(-1).ToString("yyyy-M-d");
                }
            }


            DataTable dtInfo = new DataTable();
            dtInfo.Columns.Add("name", typeof(string));
            ds.Tables.Add(dtInfo);

            DataRow row = ds.Tables[1].NewRow();
            row[0] = emp.Name;
            dtInfo.Rows.InsertAt(row, 0);

            DataRow row1 = ds.Tables[1].NewRow();
            row1["name"] = DateTime.Now.ToString("yyyy-M-d HH:mm:ss");
            dtInfo.Rows.InsertAt(row1, 0);

            DataRow row2 = ds.Tables[1].NewRow();
            row2["name"] = PeriodTime;
            dtInfo.Rows.InsertAt(row2, 0);

            if (ucpage.Name == "updgvSummary")
            {
                ee.Export(ds, "kqzdhz", folderBrowserDialog1.SelectedPath + "\\销售汇总表");
            }
            else
            {
                ee.Export(ds, "kqzdmx", folderBrowserDialog1.SelectedPath + "\\销售明细表");
            }
            
            System.Diagnostics.Process.Start("Explorer.exe", folderBrowserDialog1.SelectedPath);
            DialogResult = DialogResult.OK;
        }
    }
}
