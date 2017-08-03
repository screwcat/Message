using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Message.Model;
using Service.Common.Data;

namespace WinApp.WinForm
{
    public partial class FormMergeBill : Form
    {
        Sale SaleInfo = new Sale();
        Int32 OriginalID;
        Int32 MergerID;
        public FormMergeBill(Int32 originalID)
        {
            InitializeComponent();
            OriginalID = originalID;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxCustemerNo.Text.Trim() != "")
            {
                if (tbxCustemerNo.Text.Trim() != OriginalID.ToString())
                {
                    LoadInfo(Convert.ToInt32(tbxCustemerNo.Text));
                }
                else
                {
                    MessageBox.Show("不能和自己合并！");
                }
            }
        }

        private void LoadInfo(Int32 CustomerNo)
        {
            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "Customer = {0}", CustomerNo.ToString() });
            liWhere.Add(new string[] { "State = {0}", "1" });
            DataTable CusDt = SaleInfo.GetDataSet("SELECT TOP 1 Sale_ID FROM Sale", liWhere);
            if (CusDt.Rows.Count > 0)
            {
                MergerID = Convert.ToInt32(CusDt.Rows[0][0]);
                SaleInfo.FindbyPK(MergerID.ToString());
                lbCanNotFind.Visible = false;
            }
            else
            {
                lbCanNotFind.Visible = true;
                return;
            }
            List<string[]> where = new List<string[]>();
            List<string[]> order = new List<string[]>();
            where.Add(new string[] { "SaleOrder_ID = {0}", MergerID.ToString() });
            order.Add(new string[] { "a.Sale_Dtl_Time", "ASC" });
            DataTable dt = SaleInfo.GetDataSet("SELECT b.Product_ID,b.Code,b.Name,convert(numeric(18,2),a.Price) AS PaidIn,convert(numeric(18,2),b.Price) AS Price,convert(numeric(18,2),a.Quantity) AS Quantity,convert(numeric(18,2),a.Price/b.Price) AS Discount, convert(numeric(18,2),a.Price*a.Quantity) AS Total,a.Employee_ID FROM Sale_Detail a LEFT JOIN Product b ON b.Product_ID = a.Product_ID", where, order);
            dataGridView1.DataSource = dt;
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("确认合并吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Int32 result = ExecuteSql.ExeComSqlForNonQuery("UPDATE Sale_Detail SET SaleOrder_ID = " + OriginalID + " WHERE SaleOrder_ID = " + MergerID);

                    if (result == dataGridView1.Rows.Count)
                    {
                        DialogResult = DialogResult.OK;
                        List<string> strDel = new List<string>();
                        strDel.Add(SaleInfo.Sale_ID.ToString());
                        SaleInfo.Delete(strDel);
                    }
                    else
                    {
                        MessageBox.Show("合并失败！");
                        DialogResult = DialogResult.No;
                    }
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= dataGridView1.FirstDisplayedScrollingRowIndex)
            {
                using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
                {
                    int linen = 0;
                    linen = e.RowIndex + 1;
                    string line = linen.ToString();
                    e.Graphics.DrawString(line, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X, e.RowBounds.Location.Y + 5);
                    SolidBrush B = new SolidBrush(Color.Red);
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal TotalAmount = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TotalAmount += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Total"].Value);
            }
            lbTotal.Text = TotalAmount.ToString();
        }
    }
}
