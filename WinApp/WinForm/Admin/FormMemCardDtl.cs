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
using System.Threading;

namespace WinApp.WinForm.Admin
{
    public partial class FormMemCardDtl : Form
    {
        MemberCard CardInfo = new MemberCard();
        Int32 CardID;
        public FormMemCardDtl(Int32 cardId)
        {
            InitializeComponent();
            CardID = cardId;
            GetMemberInfo();
            Employee emp = new Employee();
            emp.FindbyPK(Thread.CurrentPrincipal.Identity.Name);
            if (emp.Dept_ID != 0)
            {
                btnRecharge.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void GetMemberInfo()
        {
            CardInfo.FindbyPK(CardID.ToString());
            tbxCardNo.Text = CardInfo.CardNO;
            tbxMemberName.Text = CardInfo.MemberName;
            ControlCommon.BindCardType(cbCardType);
            cbCardType.SelectedValue = CardInfo.CardType.ToString();
            tbxUserTel.Text = CardInfo.UserTel;
            tbxHandleTime.Text = CardInfo.HandleTime.ToString("yyyy-M-d HH:mm:ss");
            tbxLastUse.Text = CardInfo.LastUse.ToString("yyyy-M-d HH:mm:ss");
            tbxBalance.Text = CardInfo.Balance.ToString("f2");
            tbxRemarks.Text = CardInfo.Remarks;

            dataGridView1.AutoGenerateColumns = false;
            ucPage1.DataSetSql = "SELECT ID, CardID, CASE RecType WHEN 0 THEN '消费' WHEN 1 THEN '充值' END AS RecType, Amount, OpeTime, TradeNo FROM ConsumptionRecords";
            ucPage1.LiWhere.Add(new string[] { "CardID = {0}", CardID.ToString() });
            ucPage1.LiOrder.Add(new string[] { "OpeTime", "DESC" });
            dataGridView1.DataSource = ucPage1.GetDataTable();
            ucPage1.PageEvent += new WinApp.Controls.PageEntrust(ucPage1_PageEvent);
        }

        void ucPage1_PageEvent()
        {
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxMemberName.Text.Trim() == "")
            {
                MessageBox.Show("请填写用户名！");
                tbxMemberName.Focus();
                return;
            }
            if (tbxUserTel.Text.Trim() == "")
            {
                MessageBox.Show("请填写联系电话！");
                tbxUserTel.Focus();
                return;
            }
            CardInfo.MemberName = tbxMemberName.Text;
            CardInfo.UserTel = tbxUserTel.Text;
            CardInfo.CardType = Convert.ToInt32(cbCardType.SelectedValue);
            CardInfo.Remarks = tbxRemarks.Text;
            CardInfo.Update();
            MessageBox.Show("保存成功！");
            DialogResult = DialogResult.OK;
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            FormRecharge fr = new FormRecharge(CardInfo.ID);
            if (fr.ShowDialog()==DialogResult.OK)
            {
                GetMemberInfo();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
