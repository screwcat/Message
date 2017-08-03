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
    public partial class FormCreateCard : Form
    {
        MemberCard mc = new MemberCard();
        public FormCreateCard()
        {
            InitializeComponent();
            ControlCommon.BindCardType(cbCardType);
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (tbxCardNO.Text.Trim() == "")
            {
                MessageBox.Show("请填写卡号！");
                tbxCardNO.Focus();
                return;
            }
            if (this.tbxMemberName.Text.Trim() == "")
            {
                MessageBox.Show("请填写用户姓名！");
                tbxMemberName.Focus();
                return;
            }
            if (this.tbxUserTel.Text.Trim() == "")
            {
                MessageBox.Show("请填写电话！");
                tbxUserTel.Focus();
                return;
            }
            
            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "CardNO = {0}", tbxCardNO.Text });
            if (mc.GetDataSetCount("SELECT ID FROM MemberCard", liWhere) > 0)
            {
                MessageBox.Show("该卡号已经存在！");
                return;
            }
            mc.CardNO = tbxCardNO.Text;
            mc.CardType = Convert.ToInt32(cbCardType.SelectedValue);
            mc.MemberName = tbxMemberName.Text;
            mc.UserTel = tbxUserTel.Text;
            mc.PassWord = "";
            mc.UserPic = "";
            mc.Balance = 0;
            mc.HandleTime = DateTime.Now;
            mc.LastUse = DateTime.Now;
            mc.State = 1;
            mc.Remarks = tbxRemarks.Text;
            if (mc.Insert().IsSucessed)
            {
                MessageBox.Show("办卡成功！");
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
