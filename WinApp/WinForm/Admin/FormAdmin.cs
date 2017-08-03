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

namespace WinApp.WinForm.Admin
{
    public partial class FormAdmin : Form
    {
        Discount dct = new Discount();
        CardType ct = new CardType();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            dgvEmployee.AutoGenerateColumns = false;
            ucPage1.DataSetSql = "SELECT * FROM Employee";
            ucPage1.LiOrder.Add(new string[] { "Employee_ID", "ASC" });
            ucPage2.LiOrder.Add(new string[] { "Product_ID", "DESC" });
            dgvEmployee.DataSource = ucPage1.GetDataTable();
            ucPage1.PageEvent += new WinApp.Controls.PageEntrust(ucPage1_PageEvent);
        }

        void ucPage1_PageEvent()
        {
            dgvEmployee.DataSource = ucPage1.GetDataTable();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormEmpDtl fed = new FormEmpDtl(Convert.ToInt32(dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells["Employee_ID"].Value));
            if (fed.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("修改成功！");
                dgvEmployee.DataSource = ucPage1.GetDataTable();
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormEmpDtl fed = new FormEmpDtl(0);
            if (fed.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("保存成功！");
                dgvEmployee.DataSource = ucPage1.GetDataTable();
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dgvProduct.AutoGenerateColumns = false;
            ucPage2.DataSetSql = "SELECT * FROM Product";
            dgvProduct.DataSource = ucPage2.GetDataTable();
            ucPage2.PageEvent += new WinApp.Controls.PageEntrust(ucPage2_PageEvent);
        }
        void ucPage2_PageEvent()
        {
            dgvProduct.DataSource = ucPage2.GetDataTable();
        }

        private void dgvProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormProdDtl fpd = new FormProdDtl(Convert.ToInt32(dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].Cells["Product_ID"].Value));
            if (fpd.ShowDialog() == DialogResult.OK)
            {
                dgvProduct.DataSource = ucPage2.GetDataTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProdDtl fpd = new FormProdDtl(0);
            if (fpd.ShowDialog() == DialogResult.OK)
            {
                dgvProduct.DataSource = ucPage2.GetDataTable();
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            BindDiscount();
        }

        private void BindDiscount()
        {
            dgvDiscount.AutoGenerateColumns = false;
            DataSet dsDiscount = ExecuteSql.ExeComSqlForDataSet("SELECT * FROM Discount");
            dgvDiscount.DataSource = dsDiscount.Tables[0];
        }

        private void dgvDiscount_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= dgvDiscount.FirstDisplayedScrollingRowIndex)
            {
                using (SolidBrush b = new SolidBrush(dgvDiscount.RowHeadersDefaultCellStyle.ForeColor))
                {
                    int linen = 0;
                    linen = e.RowIndex + 1;
                    string line = linen.ToString();
                    e.Graphics.DrawString(line, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X, e.RowBounds.Location.Y + 5);
                    SolidBrush B = new SolidBrush(Color.Red);
                }
            }
        }

        private void dgvDiscount_SelectionChanged(object sender, EventArgs e)
        {
            getDiscountDtl();
        }

        private void getDiscountDtl()
        {
            dct.FindbyPK(dgvDiscount.Rows[dgvDiscount.CurrentCell.RowIndex].Cells["DiscountID"].Value.ToString());
            tbxDisName.Text = dct.DisName;
            tbxDiscountRate.Text = dct.DiscountRate.ToString("f2");
            if (dct.Available)
            {
                rbAvailable.Checked = true;
            }
            else
            {
                rbNotAvailable.Checked = true;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            Int32 selectRow = 0;
            if (dgvDiscount.CurrentCell.RowIndex >= 0)
            {
                selectRow = dgvDiscount.CurrentCell.RowIndex;
            }
            dct.FindbyPK(dgvDiscount.Rows[dgvDiscount.CurrentCell.RowIndex].Cells["DiscountID"].Value.ToString());
            dct.DisName = tbxDisName.Text;
            dct.DiscountRate = Convert.ToDecimal(tbxDiscountRate.Text);
            if (rbAvailable.Checked)
            {
                dct.Available = true;
            }
            else
            {
                dct.Available = false;
            }
            dct.Update();
            BindDiscount();
            dgvDiscount.CurrentCell = dgvDiscount[0, selectRow];
            getDiscountDtl();
        }

        private void tbxDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            FormAddDiscount fad = new FormAddDiscount();
            fad.ShowDialog();
            BindDiscount();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            BindCardType();
        }

        private void BindCardType()
        {
            dgvCardType.AutoGenerateColumns = false;
            DataSet dsCardType = ExecuteSql.ExeComSqlForDataSet("SELECT ID, TypeName, Discount, CASE Available WHEN 1 THEN '可用' WHEN 0 THEN '不可用' END AS Available  FROM CardType");
            dgvCardType.DataSource = dsCardType.Tables[0];
            ControlCommon.BindDiscount(cbDiscount);
        }

        private void dgvCardType_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= dgvCardType.FirstDisplayedScrollingRowIndex)
            {
                using (SolidBrush b = new SolidBrush(dgvCardType.RowHeadersDefaultCellStyle.ForeColor))
                {
                    int linen = 0;
                    linen = e.RowIndex + 1;
                    string line = linen.ToString();
                    e.Graphics.DrawString(line, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X, e.RowBounds.Location.Y + 5);
                    SolidBrush B = new SolidBrush(Color.Red);
                }
            }
        }

        private void dgvCardType_SelectionChanged(object sender, EventArgs e)
        {
            getCardTypeDtl();
        }

        private void getCardTypeDtl()
        {
            ct.FindbyPK(dgvCardType.Rows[dgvCardType.CurrentCell.RowIndex].Cells["CardTypeID"].Value.ToString());
            tbxCardTypeName.Text = ct.TypeName;
            cbDiscount.SelectedValue = ct.Discount;
            if (ct.Available == 1)
            {
                rbctAvailable.Checked = true;
            }
            else
            {
                rbctNotAvailable.Checked = true;
            }
        }

        private void btnCreateType_Click(object sender, EventArgs e)
        {
            FormCreateCardType fcct = new FormCreateCardType();
            if (fcct.ShowDialog() == DialogResult.OK)
            {
                BindCardType();
            }
        }

        private void btnSaveCardType_Click(object sender, EventArgs e)
        {
            Int32 selectRow = 0;
            if (dgvCardType.CurrentCell.RowIndex >= 0)
            {
                selectRow = dgvCardType.CurrentCell.RowIndex;
            }
            ct.FindbyPK(dgvCardType.Rows[dgvCardType.CurrentCell.RowIndex].Cells["CardTypeID"].Value.ToString());
            ct.TypeName = tbxCardTypeName.Text;
            ct.Discount = Convert.ToDecimal(cbDiscount.SelectedValue);
            if (rbctAvailable.Checked)
            {
                ct.Available = 1;
            }
            else
            {
                ct.Available = 0;
            }
            ct.Update();
            BindCardType();
            dgvCardType.CurrentCell = dgvCardType[0, selectRow];
            getCardTypeDtl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ucPage2.LiWhere.Clear();
            if (!string.IsNullOrEmpty(tbxProCode.Text.Trim()))
            {
                ucPage2.LiWhere.Add(new string[] { "Code LIKE '%' + {0} + '%'", tbxProCode.Text.Trim() });
            }
            if (!string.IsNullOrEmpty(tbxProName.Text.Trim()))
            {
                ucPage2.LiWhere.Add(new string[] { "Name LIKE '%' + {0} + '%'", tbxProName.Text.Trim() });
            }
            if (!string.IsNullOrEmpty(tbxPinYin.Text.Trim()))
            {
                ucPage2.LiWhere.Add(new string[] { "(spell LIKE '%' + {0} + '%' OR s_spell LIKE '%' + {0} + '%')", tbxPinYin.Text.Trim() });
            }
            dgvProduct.DataSource = ucPage2.GetDataTable();
        }

        private void tbxProCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigital(e);
        }
    }
}
