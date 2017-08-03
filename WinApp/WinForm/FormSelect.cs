using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.Common.Data;
using Message.Model;
using Service.Common;
using System.Threading;

namespace WinApp.WinForm
{
    public partial class FormSelect : Form
    {
        Product emp = new Product();
        SaleDtlInfo saleInfo = new SaleDtlInfo();
        public SaleDtlInfo SaleInfo
        {
            get { return saleInfo; }
            set { saleInfo = value; }
        }
        public FormSelect()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ControlCommon.BindDiscount(cbDiscount);
            BindProData();
            ControlCommon.BindEmployee(cbServer);
            DataTable dt = (DataTable)cbServer.DataSource;
            DataRow dr = dt.NewRow();
            dr["Employee_ID"] = 0;
            dr["Name"] = "<—请选择—>";
            dt.Rows.InsertAt(dr, 0);
            cbServer.SelectedIndex = 0;
        }

        private void BindProData()
        {
            List<string[]> where = new List<string[]>();
            if (!string.IsNullOrEmpty(tbxCode.Text.Trim()))
            {
                where.Add(new string[] { "Code LIKE '%' + {0} + '%'", tbxCode.Text.Trim() });
            }
            if (!string.IsNullOrEmpty(tbxPinYin.Text.Trim()))
            {
                where.Add(new string[] { "(spell LIKE '%' + {0} + '%' OR s_spell LIKE '%' + {0} + '%')", tbxPinYin.Text.Trim() });
            }

            DataTable dt = emp.GetDataSet("SELECT * FROM Product", where);
            dataGridView1.DataSource = dt;
        }
        private void tbxNo_TextChanged(object sender, EventArgs e)
        {
            BindProData();
            CalcAmount();
        }

        private void tbxPinYin_TextChanged(object sender, EventArgs e)
        {
            BindProData();
            CalcAmount();
        }

        private void cbDiscount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void CalcAmount()
        {
            if (((DataTable)(dataGridView1.DataSource)).Rows.Count > 0 && tbxQty.Text.Length > 0 && tbxQty.Text != "-")
            {
                decimal Price = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Price"].Value);
                decimal Amount = Price * Convert.ToDecimal(cbDiscount.SelectedValue) * Convert.ToInt32(tbxQty.Text);
                lbAmount.Text = Math.Round(Amount, 2).ToString();
                //lbAmount.Text = ((Int32)((double)Amount + 0.5)).ToString();
            }
            else
            {
                lbAmount.Text = "--";
            }
        }

        private void tbxQty_TextChanged(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void tbxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigitalHL(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (cbServer.SelectedValue.ToString() != "0")
            {
                if (dataGridView1.Rows.Count > 0 && lbAmount.Text != "--")
                {
                    if (Convert.ToDecimal(lbAmount.Text) >= 0)
                    {
                        SetSaleInfo();
                    }
                    else
                    {
                        if (new FormBackPassword().ShowDialog() == DialogResult.OK)
                        {
                            SetSaleInfo();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择服务人员！");
            }
        }

        private void SetSaleInfo()
        {
            SaleInfo.ProID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ProID"].Value);
            SaleInfo.ProCode = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Code"].Value.ToString();
            SaleInfo.ProName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ProName"].Value.ToString();
            SaleInfo.Price = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Price"].Value);
            SaleInfo.PaidIn = Convert.ToDecimal(lbAmount.Text);
            SaleInfo.Quanity = Convert.ToDecimal(tbxQty.Text);
            SaleInfo.Discount = Convert.ToDecimal(cbDiscount.SelectedValue);
            SaleInfo.Total = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Price"].Value) * Convert.ToDecimal(cbDiscount.SelectedValue);
            SaleInfo.ServerID = Convert.ToInt32(cbServer.SelectedValue);
            saleInfo.Sale_Dtl_Time = DateTime.Now;
            saleInfo.Server = cbServer.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void tbxServicePerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigital(e);
        }
    }
}
