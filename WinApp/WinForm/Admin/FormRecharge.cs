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

namespace WinApp.WinForm.Admin
{
    public partial class FormRecharge : Form
    {
        MemberCard mc = new MemberCard();
        public FormRecharge(Int32 cardId)
        {
            InitializeComponent();
            mc.FindbyPK(cardId.ToString());
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (tbxRechargeAmount.Text.Trim() != "")
            {
                if (new FormBackPassword().ShowDialog() == DialogResult.OK)
                {
                    if (MessageBox.Show("您确定要向卡号：" + mc.CardNO + " 姓名：" + mc.MemberName + " 的用户充值 " + tbxRechargeAmount.Text + " 元吗？", "充值确认", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        mc.Balance += Convert.ToInt32(tbxRechargeAmount.Text);
                        mc.Update();
                        ConsumptionRecords cr = new ConsumptionRecords();
                        cr.CardID = mc.ID;
                        cr.RecType = 1;
                        cr.TradeNo = "-----------";
                        cr.OpeTime = DateTime.Now;
                        cr.Amount = Convert.ToInt32(tbxRechargeAmount.Text);
                        cr.Insert();
                        MessageBox.Show("充值成功！");
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show("请填写充值金额！");
            }
        }

        private void tbxRechargeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigitalHL(sender, e);
        }
    }
}
