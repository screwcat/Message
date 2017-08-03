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
    public partial class FormMemCard : Form
    {
        MemberCard mc = new MemberCard();
        CardType ct = new CardType();
        string cardNo;
        decimal paymentCard;

        public decimal PaymentCard
        {
            get { return paymentCard; }
            set { paymentCard = value; }
        }
        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }
        public FormMemCard(decimal TotalAmount)
        {
            InitializeComponent();
            lbAmount.Text = TotalAmount.ToString("f2");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxCardNo.Text.Trim()!="")
            {
                List<string[]> where = new List<string[]>();
                where.Add(new string[] { "CardNO = {0}", tbxCardNo.Text.Trim() });
                DataTable dt = mc.GetDataSet("SELECT TOP 1 ID FROM MemberCard", where);
                if (dt.Rows.Count > 0)
                {
                    string CardID = dt.Rows[0][0].ToString();
                    mc.FindbyPK(CardID);
                    ct.FindbyPK(mc.CardType.ToString());
                    this.lbCardType.Text = ct.TypeName;
                    lbCardNo.Text = mc.CardNO;
                    lbMemberName.Text = mc.MemberName;
                    lbUserTel.Text = mc.UserTel;
                    lbHandleTime.Text = mc.HandleTime.ToString("yyyy-MM-dd HH:mm:ss");
                    lbLastUse.Text = mc.LastUse.ToString("yyyy-MM-dd HH:mm:ss");
                    lbBalance.Text = mc.Balance.ToString("f2");
                    if (tbxConsumption.Text == "")
                    {
                        if (Convert.ToDecimal(lbBalance.Text) >= Convert.ToDecimal(lbAmount.Text))
                        {
                            tbxConsumption.Text = lbAmount.Text;
                        }
                        else
                        {
                            tbxConsumption.Text = lbBalance.Text;
                        }
                    }
                    lbCannotFind.Visible = false;
                }
                else
                {
                    lbMemberName.Text = "";
                    lbCardType.Text = "";
                    lbMemberName.Text = "";
                    lbUserTel.Text = "";
                    lbHandleTime.Text = "";
                    lbLastUse.Text = "";
                    lbBalance.Text = "";
                    lbCannotFind.Visible = true;
                    tbxConsumption.Text = "";
                    lbCardNo.Text = "";
                }
            }
        }


        private void tbxlbConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (lbCardNo.Text!="")
            {
                if (Convert.ToDecimal(tbxConsumption.Text) >= 0 && Convert.ToDecimal(tbxConsumption.Text) <= Convert.ToDecimal(lbBalance.Text) && Convert.ToDecimal(tbxConsumption.Text) <= Convert.ToDecimal(lbAmount.Text))
                {
                    paymentCard = Convert.ToDecimal(tbxConsumption.Text);
                    cardNo = lbCardNo.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("消费金额输入有误！");
                }
            }
        }
    }
}
