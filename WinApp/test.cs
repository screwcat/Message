using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.Common.Data;

namespace WinApp
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn dgvComboBoxColumn = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["Discount"];
            dgvComboBoxColumn.DataPropertyName = "Discount";
            dgvComboBoxColumn.DataSource = ExecuteSql.ExeComSqlForDataSet("SELECT DiscountRate,DisName FROM Discount WHERE Available = 1").Tables[0];
            dgvComboBoxColumn.DisplayMember = "DisName";
            dgvComboBoxColumn.ValueMember = "DiscountRate";

            DataTable dt = ExecuteSql.ExeComSqlForDataSet("SELECT * FROM dbo.v_SaleDetailList WHERE SaleOrder_ID = 88").Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal TotalAmount = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TotalAmount += Convert.ToDecimal(dataGridView1.Rows[i].Cells["PaidIn"].Value);
            }
            //lbTotal.Text = TotalAmount.ToString();
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
    }
}
