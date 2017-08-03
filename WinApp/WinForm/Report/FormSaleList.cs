using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinApp.WinForm.Report
{
    public partial class FormSaleList : Form
    {
        public FormSaleList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
        }

        private void FormSaleList_Load(object sender, EventArgs e)
        {
            ucPage1.DataSetSql = "SELECT * FROM v_SaleList";
            ucPage1.LiWhere.Add(new string[] { "State = {0}", "0" });
            ucPage1.LiOrder.Add(new string[] { "Sale_ID", "DESC" });
            dataGridView1.DataSource = ucPage1.GetDataTable();

            ucPage2.DataSetSql = "SELECT ID,StartTime,EndTime,ShiftUser,Name,ShiftTime,'～' AS WaveLine FROM ShiftInfo LEFT JOIN Employee ON ShiftUser = Employee_ID";
            //ucPage2.LiWhere.Add(new string[] { "1={0}", "1" });
            ucPage2.LiOrder.Add(new string[] { "y.ID", "DESC" });
            dataGridView2.DataSource = ucPage2.GetDataTable();
            ucPage1.PageEvent += new WinApp.Controls.PageEntrust(ucPage1_PageEvent);
            ucPage2.PageEvent += new WinApp.Controls.PageEntrust(ucPage2_PageEvent);
        }

        void ucPage1_PageEvent()
        {
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        void ucPage2_PageEvent()
        {
            dataGridView2.DataSource = ucPage2.GetDataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ucPage1.LiWhere.Clear();
            ucPage1.LiWhere.Add(new string[] { "State = {0}", "0" });
            if (dtpFrom.Checked)
            {
                ucPage1.LiWhere.Add(new string[] { "CheckoutTime > {0}", dtpFrom.Value.ToShortDateString() });
            }
            if (dtpTo.Checked)
            {
                ucPage1.LiWhere.Add(new string[] { "CheckoutTime < {0}", dtpTo.Value.AddDays(1).ToShortDateString() });
            }
            if (tbxTradCode.Text.Trim() != "")
            {
                ucPage1.LiWhere.Add(new string[] { "TradeNo LIKE '%' + {0} + '%'", tbxTradCode.Text.Trim() });
            }
            if (tbxOrderNo.Text.Trim() != "")
            {
                ucPage1.LiWhere.Add(new string[] { "OrderNo LIKE '%' + {0} + '%'", tbxOrderNo.Text.Trim() });
            }
            ucPage1.CurPage = 1;
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormSaleDetail fsd = new FormSaleDetail(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Sale_ID"].Value));
            fsd.ShowDialog(this);
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormShift fs = new FormShift(Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["ShiftID"].Value));
            fs.ShowDialog();
        }

    }
}
