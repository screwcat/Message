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
using Service.Common;
using Service.Common.IO;

namespace WinApp.WinForm.Admin
{
    public partial class FormProdDtl : Form
    {
        Product pro = new Product();
        public FormProdDtl(Int32 ProID)
        {
            InitializeComponent();
            tbxName.Focus();
            if (ProID != 0)
            {
                LoadInfo(ProID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxName.Text.Trim() == "")
            {
                MessageBox.Show("请填写名称！");
                return;
            }
            if (tbxPrice.Text.Trim() == "")
            {
                MessageBox.Show("请填写价格！");
                return;
            }
            if (tbxCommission.Text.Trim() == "")
            {
                MessageBox.Show("请填写提成！");
                return;
            }
            pro.Code = tbxCode.Text;
            pro.Name = tbxName.Text;
            PinyinCommon pyc = new PinyinCommon();
            pro.spell = pyc.GetQuanPing(tbxName.Text.Trim());
            pro.s_spell = pyc.GetPYString(tbxName.Text.Trim());
            pro.shortname = tbxName.Text;
            pro.Price = Convert.ToDecimal(tbxPrice.Text);
            pro.Offering_Price = Convert.ToDecimal(tbxPrice.Text);
            pro.Commission = Convert.ToDecimal(tbxCommission.Text);
            pro.Remark = tbxRemark.Text;
            if (pro.Product_ID == 0)
            {
                List<string[]> LiWhere = new List<string[]>();
                LiWhere.Add(new string[] { "Name = {0}", tbxName.Text });
                DataTable dt = pro.GetDataSet("SELECT Product_ID FROM Product", LiWhere);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("该商品名已存在！");
                    return;
                }
                pro.ProductList_ID = 1;
                pro.ProductSpec_ID = 1;
                pro.ProductUnit_ID = 1;
                pro.Employee_ID = Convert.ToInt32(Thread.CurrentPrincipal.Identity.Name);
                pro.CreateDate = DateTime.Now;
                string newProId = pro.Insert().Message;
                pro.FindbyPK(newProId);
                pro.Code = Convert.ToInt32(newProId).ToString("000");
                pro.Update();
            }
            else
            {
                pro.Update();
            }
            MessageBox.Show("保存成功！");
            DialogResult = DialogResult.OK;
        }

        private void LoadInfo(Int32 proID)
        {
            pro.FindbyPK(proID.ToString());
            tbxCode.Text = pro.Code;
            tbxName.Text = pro.Name;
            tbxPrice.Text = pro.Price.ToString("f2");
            tbxCommission.Text = pro.Commission.ToString("f2");
            tbxCreateDate.Text = pro.CreateDate.ToString("yyyy-MM-dd HH:mm:ss");
            Employee emp = new Employee();
            emp.FindbyPK(pro.Employee_ID.ToString());
            tbxEmployee_ID.Text = emp.Name;
            tbxRemark.Text = pro.Remark;
            tbxCreateDate.ReadOnly = true;
            tbxEmployee_ID.ReadOnly = true;
        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }
    }
}
