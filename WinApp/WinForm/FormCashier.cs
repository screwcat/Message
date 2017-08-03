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

namespace WinApp.WinForm
{
    public partial class FormCashier : Form
    {
        Sale SaleInfo = new Sale();
        PaymentInfo paymentInfo = new PaymentInfo();

        public PaymentInfo PaymentInfo
        {
            get { return paymentInfo; }
            set { paymentInfo = value; }
        }
        public FormCashier(Int32 Sale_ID)
        {
            InitializeComponent();
            SaleInfo.FindbyPK(Sale_ID.ToString());
            tbxAmount.Text = SaleInfo.TotalAmount.ToString("f2");
            tbxCash.Text = SaleInfo.TotalAmount.ToString("f2");
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbxAmount.Text.Trim()!="")
            {
                if (Convert.ToDecimal(tbxAmount.Text) == Convert.ToDecimal(tbxCash.Text) + Convert.ToDecimal(tbxUnionPay.Text) + Convert.ToDecimal(tbxOtherPayment.Text) + Convert.ToDecimal(tbxCardPayment.Text))
                {
                    paymentInfo.TotalAmount = Convert.ToDecimal(tbxAmount.Text);
                    paymentInfo.Cash = Convert.ToDecimal(tbxCash.Text);
                    paymentInfo.UnionPay = Convert.ToDecimal(tbxUnionPay.Text);
                    paymentInfo.OtherPayment = Convert.ToDecimal(tbxOtherPayment.Text);
                    paymentInfo.MemCard = Convert.ToDecimal(tbxCardPayment.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("消费数额填写有误！");
                }
            }
            else
            {
                MessageBox.Show("请填写消费金额！");
            }
        }

        private void btnChooseCard_Click(object sender, EventArgs e)
        {
            if (tbxAmount.Text.Trim()!="")
            {
                FormMemCard fmc = new FormMemCard(Convert.ToDecimal(tbxAmount.Text));
                if (fmc.ShowDialog() == DialogResult.OK)
                {
                    tbxCardPayment.Text = fmc.PaymentCard.ToString("f2");
                    ClearAllText();
                    tbxCash.Text = (Convert.ToDecimal(tbxAmount.Text) - Convert.ToDecimal(tbxCardPayment.Text)).ToString("f2");
                    lbCardNo.Text = "No：" + fmc.CardNo;
                    paymentInfo.Account = fmc.CardNo;
                    lbCardNo.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("请填写消费金额！");
            }
        }

        private void ClearAllText()
        {
            tbxCash.Text = "0.00";
            tbxUnionPay.Text = "0.00";
            tbxOtherPayment.Text = "0.00";
        }


        private void tbxAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxAmount.Text.Trim()!="")
            {
                ClearAllText();
                decimal cash = Convert.ToDecimal(tbxAmount.Text) - Convert.ToDecimal(tbxCardPayment.Text);
                if (cash >= 0)
                {
                    tbxCash.Text = cash.ToString("f2");
                }
                tbxAmount.Focus();
            }
            else
            {
                ClearAllText();
                tbxAmount.Focus();
            }
        }

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void tbxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void tbxUnionPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void tbxOtherPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }
    }
}
