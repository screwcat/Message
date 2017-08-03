using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Message.Model;
using Service.Common;
using System.Threading;

namespace WinApp.WinForm.Report
{
    public partial class FormReport : Form
    {
        Sale SaleInfo = new Sale();
        public FormReport()
        {
            InitializeComponent();
            dgvSummary.AutoGenerateColumns = false;
            dgvDetail.AutoGenerateColumns = false;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            updgvSummary.DataSetSql = "SELECT * FROM v_SaleList";
            updgvSummary.LiWhere.Add(new string[] { "State = {0}", "0" });
            updgvSummary.LiOrder.Add(new string[] { "Sale_ID", "DESC" });
            dgvSummary.DataSource = updgvSummary.GetDataTable();
            updgvSummary.PageEvent += new WinApp.Controls.PageEntrust(updgvSummary_PageEvent);
            updgvDetail.PageEvent += new WinApp.Controls.PageEntrust(updgvDetail_PageEvent);
            GetTotalAmount();
            ControlCommon.BindEmployee(cbServer);
            DataTable dt = (DataTable)cbServer.DataSource;
            DataRow dr = dt.NewRow();
            dr["Employee_ID"] = 0;
            dr["Name"] = "<—全部—>";
            dt.Rows.InsertAt(dr, 0);
            cbServer.SelectedIndex = 0;
            ControlCommon.BindProduct(cbProName);
            DataTable dt1 = (DataTable)cbProName.DataSource;
            DataRow dr1 = dt1.NewRow();
            dr1["Product_ID"] = 0;
            dr1["Name"] = "<—全部—>";
            dt1.Rows.InsertAt(dr1, 0);
            cbProName.SelectedIndex = 0;
        }

        void updgvSummary_PageEvent()
        {
            dgvSummary.DataSource = updgvSummary.GetDataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updgvSummary.LiWhere.Clear();
            updgvSummary.LiWhere.Add(new string[] { "State = {0}", "0" });
            if (dtpFrom.Checked)
            {
                updgvSummary.LiWhere.Add(new string[] { "CheckoutTime > {0}", dtpFrom.Value.ToShortDateString() });
            }
            if (dtpTo.Checked)
            {
                updgvSummary.LiWhere.Add(new string[] { "CheckoutTime < {0}", dtpTo.Value.AddDays(1).ToShortDateString() });
            }
            if (tbxTradCode.Text.Trim() != "")
            {
                updgvSummary.LiWhere.Add(new string[] { "TradeNo LIKE '%' + {0} + '%'", tbxTradCode.Text.Trim() });
            }
            if (tbxOrderNo.Text.Trim() != "")
            {
                updgvSummary.LiWhere.Add(new string[] { "OrderNo LIKE '%' + {0} + '%'", tbxOrderNo.Text.Trim() });
            }
            updgvSummary.CurPage = 1;
            dgvSummary.DataSource = updgvSummary.GetDataTable();
            GetTotalAmount();
        }
        private void GetTotalAmount()
        {
            DataTable dt = SaleInfo.GetDataSet("SELECT SUM(TotalAmount) FROM v_SaleList", updgvSummary.LiWhere);
            if (dt.Rows[0][0] != System.DBNull.Value)
            {
                lbTotalAmount.Text = (Convert.ToDecimal(dt.Rows[0][0])).ToString("f2") + " 元";
            }
            else
            {
                lbTotalAmount.Text = "0 元";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FormExport fe = new FormExport(updgvSummary);
            fe.ShowDialog();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            updgvDetail.LiOrder.Clear();
            updgvDetail.LiWhere.Clear();
            updgvDetail.LiOrder.Add(new string[] { "Sale_Detail_ID", "DESC" });
            updgvDetail.LiWhere.Add(new string[] { "State = {0}", "0" });
            updgvDetail.DataSetSql = "SELECT * FROM v_SaleDetailList";
            dgvDetail.DataSource = updgvDetail.GetDataTable();
            GetDtlTotalAmount();
        }

        void updgvDetail_PageEvent()
        {
            dgvDetail.DataSource = updgvDetail.GetDataTable();
        }

        private void GetDtlTotalAmount()
        {
            DataTable dt = SaleInfo.GetDataSet("SELECT SUM(Total),SUM(Commission) FROM v_SaleDetailList", updgvDetail.LiWhere);
            if (dt.Rows[0][0] != System.DBNull.Value)
            {
                lbDtlTotalAmount.Text = (Convert.ToDecimal(dt.Rows[0][0])).ToString("f2") + " 元";
                lbCommission.Text = (Convert.ToDecimal(dt.Rows[0][1])).ToString("f2") + " 元";
            }
            else
            {
                lbDtlTotalAmount.Text = "0 元";
                lbCommission.Text = "0 元";
            }
        }

        private void btnDtlSearch_Click(object sender, EventArgs e)
        {
            updgvDetail.LiWhere.Clear();
            updgvDetail.LiWhere.Add(new string[] { "State = {0}", "0" });
            if (dtpDtlFrom.Checked)
            {
                updgvDetail.LiWhere.Add(new string[] { "CheckoutTime > {0}", dtpDtlFrom.Value.ToShortDateString() });
            }
            if (dtpDtlTo.Checked)
            {
                updgvDetail.LiWhere.Add(new string[] { "CheckoutTime < {0}", dtpDtlTo.Value.AddDays(1).ToShortDateString() });
            }
            if (tbxDtlTradCode.Text != "")
            {
                updgvDetail.LiWhere.Add(new string[] { "TradeNo LIKE '%' + {0} + '%'", tbxDtlTradCode.Text.Trim() });
            }
            if (cbProName.SelectedValue.ToString() != "0")
            {
                updgvDetail.LiWhere.Add(new string[] { "Product_ID ={0}", cbProName.SelectedValue.ToString() });
            }
            if (cbServer.SelectedValue.ToString() != "0")
            {
                updgvDetail.LiWhere.Add(new string[] { "Employee_ID = {0}", cbServer.SelectedValue.ToString() });
            }
            if (tbxOrderNoDtl.Text.Trim() != "")
            {
                updgvDetail.LiWhere.Add(new string[] { "OrderNo LIKE '%' + {0} + '%'", tbxOrderNoDtl.Text.Trim() });
            }
            updgvDetail.CurPage = 1;
            dgvDetail.DataSource = updgvDetail.GetDataTable();
            GetDtlTotalAmount();
        }

        private void btnDtlExport_Click(object sender, EventArgs e)
        {
            FormExport fe = new FormExport(updgvDetail);
            fe.ShowDialog();
        }
    }
}
