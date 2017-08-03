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
    public partial class FormCreateCardType : Form
    {
        CardType ct = new CardType();
        public FormCreateCardType()
        {
            InitializeComponent();
            ControlCommon.BindDiscount(cbDiscount);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxctName.Text.Trim() == "")
            {
                MessageBox.Show("请填写名称！");
                tbxctName.Focus();
                return;
            }
            ct.TypeName = tbxctName.Text;
            ct.Discount = Convert.ToDecimal(cbDiscount.SelectedValue);
            ct.Available = 1;
            if (ct.Insert().IsSucessed)
            {
                MessageBox.Show("添加成功！");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加失败！");
                DialogResult = DialogResult.No;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
