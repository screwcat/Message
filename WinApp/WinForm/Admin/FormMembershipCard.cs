using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Message.Model;
using System.Threading;

namespace WinApp.WinForm.Admin
{
    public partial class FormMembershipCard : Form
    {
        public FormMembershipCard()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ucPage1.LiWhere.Clear();
            if (tbxCardNo.Text.Trim()!="")
            {
                ucPage1.LiWhere.Add(new string[] { "CardNO = {0}", tbxCardNo.Text.Trim() });
            }
            if (tbxMemName.Text.Trim()!="")
            {
                ucPage1.LiWhere.Add(new string[] { "MemberName = {0}", tbxMemName.Text.Trim() });
            }
            if (tbxMemTel.Text.Trim() != "")
            {
                ucPage1.LiWhere.Add(new string[] { "UserTel = {0}", tbxMemTel.Text.Trim() });
            }
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        private void FormMembershipCard_Load(object sender, EventArgs e)
        {
            ucPage1.DataSetSql = "SELECT CardType.TypeName, MemberCard.ID, MemberCard.CardNO, MemberCard.MemberName, MemberCard.UserTel, MemberCard.Balance, MemberCard.HandleTime FROM MemberCard LEFT OUTER JOIN CardType ON MemberCard.CardType = CardType.ID";
            ucPage1.LiOrder.Add(new string[] { "HandleTime", "DESC" });
            dataGridView1.DataSource = ucPage1.GetDataTable();
            ucPage1.PageEvent += new WinApp.Controls.PageEntrust(ucPage1_PageEvent);
            Employee emp = new Employee();
            emp.FindbyPK(Thread.CurrentPrincipal.Identity.Name);
            if (emp.Dept_ID != 0)
            {
                btnHandleCard.Enabled = false;
            }
        }

        void ucPage1_PageEvent()
        {
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormMemCardDtl fmc = new FormMemCardDtl(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value));
            if (fmc.ShowDialog()==DialogResult.OK)
            {
                dataGridView1.DataSource = ucPage1.GetDataTable();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHandleCard_Click(object sender, EventArgs e)
        {
            FormCreateCard fcc = new FormCreateCard();
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                ucPage1.LiWhere.Clear();
                dataGridView1.DataSource = ucPage1.GetDataTable();
            }
        }
    }
}
