using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinApp.WinForm.Report;
using Service.Common.Data;
using Message.Model;
using System.Threading;
using Service.Common;

namespace WinApp.WinForm
{
    public partial class FormShift : Form
    {
        Sale_Detail sd = new Sale_Detail();
        Int32 ShiftID = 0;
        public FormShift(Int32 shiftid)
        {
            ShiftID = shiftid;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dgvDetail.AutoGenerateColumns = false;
            ucPage1.DataSetSql = "SELECT * FROM v_SaleList";
            ucPage1.LiWhere.Add(new string[] { "State = {0}", "0" });
            ucPage2.DataSetSql = "SELECT * FROM v_SaleDetailList";
            ucPage2.LiWhere.Add(new string[] { "State = {0}", "0" });
            
            GetLiWhere(ShiftID);

            ucPage1.LiOrder.Add(new string[] { "Sale_ID", "DESC" });
            dataGridView1.DataSource = ucPage1.GetDataTable();
            ucPage2.LiOrder.Add(new string[] { "Sale_Detail_ID", "DESC" });
            dgvDetail.DataSource = ucPage2.GetDataTable();
            ucPage1.PageEvent += new WinApp.Controls.PageEntrust(ucPage1_PageEvent);
            ucPage2.PageEvent += new WinApp.Controls.PageEntrust(ucPage2_PageEvent);
            Sale SaleInfo = new Sale();
            DataTable dt = SaleInfo.GetDataSet("SELECT SUM(TotalAmount) AS Total,SUM(Cash) AS Cash,SUM(MemCard) AS MemCard,SUM(UnionPay) AS UnionPay,SUM(OtherPayment) AS OtherPayment FROM Sale", ucPage1.LiWhere);
            lbTotalAmount.Text = dt.Rows[0]["Total"].ToString();
            lbCash.Text = dt.Rows[0]["Cash"].ToString();
            lbMembershipCard.Text = dt.Rows[0]["MemCard"].ToString();
            lbUnionPay.Text = dt.Rows[0]["UnionPay"].ToString();
            lbOther.Text = dt.Rows[0]["OtherPayment"].ToString();
            DataTable dt1 = SaleInfo.GetDataSet("SELECT SUM(Commission) AS Commission FROM v_SaleDetailList", ucPage1.LiWhere);
            lbCommission.Text = dt1.Rows[0][0].ToString();



            ControlCommon.BindEmployee(cbServer);
            DataTable dt2 = (DataTable)cbServer.DataSource;
            DataRow dr = dt2.NewRow();
            dr["Employee_ID"] = 0;
            dr["Name"] = "<—全部—>";
            dt2.Rows.InsertAt(dr, 0);
            cbServer.SelectedIndex = 0;
            ControlCommon.BindProduct(cbProName);
            DataTable dt3 = (DataTable)cbProName.DataSource;
            DataRow dr1 = dt3.NewRow();
            dr1["Product_ID"] = 0;
            dr1["Name"] = "<—全部—>";
            dt3.Rows.InsertAt(dr1, 0);
            cbProName.SelectedIndex = 0;

            GetDtlTotalAmount();

        }




        void ucPage1_PageEvent()
        {
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }
        void ucPage2_PageEvent()
        {
            dgvDetail.DataSource = ucPage2.GetDataTable();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormSaleDetail fsd = new FormSaleDetail(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Sale_ID"].Value));
            fsd.ShowDialog(this);
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (((DataTable)(dataGridView1.DataSource)).Rows.Count > 0)
            {
                if (MessageBox.Show("确定要清帐交接吗？", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    ShiftInfo si = new ShiftInfo();
                    DataSet ds = ExecuteSql.ExeComSqlForDataSet("SELECT TOP 1 StartID,EndID,StartTime,EndTime FROM ShiftInfo ORDER BY ID DESC");
                    DataSet ds1 = ExecuteSql.ExeComSqlForDataSet("SELECT TOP 1 Sale_ID,CheckoutTime FROM Sale WHERE Sale_ID > " + ds.Tables[0].Rows[0]["EndID"].ToString() + " AND State = 0 ORDER BY Sale_ID ASC");
                    DataSet ds2 = ExecuteSql.ExeComSqlForDataSet("SELECT TOP 1 Sale_ID,CheckoutTime FROM Sale WHERE Sale_ID > " + ds.Tables[0].Rows[0]["EndID"].ToString() + " AND State = 0 ORDER BY Sale_ID DESC");
                    si.StartID = Convert.ToInt32(ds1.Tables[0].Rows[0]["Sale_ID"]);
                    si.StartTime = Convert.ToDateTime(ds1.Tables[0].Rows[0]["CheckoutTime"]);
                    si.EndID = Convert.ToInt32(ds2.Tables[0].Rows[0]["Sale_ID"]);
                    si.EndTime = Convert.ToDateTime(ds2.Tables[0].Rows[0]["CheckoutTime"]);
                    si.ShiftTime = DateTime.Now;
                    si.ShiftUser = Convert.ToInt32(Thread.CurrentPrincipal.Identity.Name);
                    si.Insert();
                    MessageBox.Show("操作成功！");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("没有销售记录不能交班！");
            }
        }

        private void btnDtlSearch_Click(object sender, EventArgs e)
        {
            ucPage2.LiWhere.Clear();
            ucPage2.LiWhere.Add(new string[] { "State = {0}", "0" });
            GetLiWhere(ShiftID);
            if (cbProName.SelectedValue.ToString() != "0")
            {
                ucPage2.LiWhere.Add(new string[] { "Product_ID ={0}", cbProName.SelectedValue.ToString() });
            }
            if (cbServer.SelectedValue.ToString() != "0")
            {
                ucPage2.LiWhere.Add(new string[] { "Employee_ID = {0}", cbServer.SelectedValue.ToString() });
            }
            if (tbxOrderNoDtl.Text.Trim() != "")
            {
                ucPage2.LiWhere.Add(new string[] { "OrderNo LIKE '%' + {0} + '%'", tbxOrderNoDtl.Text.Trim() });
            }
            ucPage2.CurPage = 1;
            dgvDetail.DataSource = ucPage2.GetDataTable();
            GetDtlTotalAmount();
        }

        private void GetDtlTotalAmount()
        {
            DataTable dt = sd.GetDataSet("SELECT SUM(Total),SUM(Commission) FROM v_SaleDetailList", ucPage2.LiWhere);
            if (dt.Rows[0][0] != System.DBNull.Value)
            {
                lbTotalAmountDtl.Text = (Convert.ToDecimal(dt.Rows[0][0])).ToString("f2") + " 元";
                lbCommissionDtl.Text = (Convert.ToDecimal(dt.Rows[0][1])).ToString("f2") + " 元";
            }
            else
            {
                lbTotalAmountDtl.Text = "0 元";
                lbCommissionDtl.Text = "0 元";
            }
        }

        private void GetLiWhere(Int32 ShiftID)
        {
            if (ShiftID == 0)
            {
                DataSet ds = ExecuteSql.ExeComSqlForDataSet("SELECT TOP 1 StartID,EndID,StartTime,EndTime FROM ShiftInfo ORDER BY ID DESC");
                ucPage1.LiWhere.Add(new string[] { "Sale_ID > {0}", ds.Tables[0].Rows[0]["EndID"].ToString() });
                ucPage2.LiWhere.Add(new string[] { "Sale_ID > {0}", ds.Tables[0].Rows[0]["EndID"].ToString() });
            }
            else
            {
                ShiftInfo si = new ShiftInfo();
                si.FindbyPK(ShiftID.ToString());
                ucPage1.LiWhere.Add(new string[] { "Sale_ID >= {0}", si.StartID.ToString() });
                ucPage1.LiWhere.Add(new string[] { "Sale_ID <= {0}", si.EndID.ToString() });
                ucPage2.LiWhere.Add(new string[] { "Sale_ID >= {0}", si.StartID.ToString() });
                ucPage2.LiWhere.Add(new string[] { "Sale_ID <= {0}", si.EndID.ToString() });
                btnShift.Visible = false;
            }
        }

    }
}
