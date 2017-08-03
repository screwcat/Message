using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.Common;
using Message.Model;

namespace WinApp.WinForm.Admin
{
    public partial class FormAddDiscount : Form
    {
        public FormAddDiscount()
        {
            InitializeComponent();
        }

        private void tbxDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxDisName.Text == "")
            {
                MessageBox.Show("请填写名称！");
                tbxDisName.Focus();
                return;
            }
            if (tbxDiscountRate.Text == "")
            {
                MessageBox.Show("请填写折扣！");
                tbxDiscountRate.Focus();
                return;
            }
            Discount dsc = new Discount();
            dsc.DisName = tbxDisName.Text;
            dsc.DiscountRate = Convert.ToDecimal(tbxDiscountRate.Text);
            if (rbAvailable.Checked)
            {
                dsc.Available = true;
            }
            else
            {
                dsc.Available = false;
            }
            dsc.Remark = "";
            dsc.Insert();
            MessageBox.Show("保存成功！");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
