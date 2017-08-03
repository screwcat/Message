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
    public partial class FormEmpDtl : Form
    {
        Employee emp = new Employee();
        public FormEmpDtl(Int32 Employee_ID)
        {
            InitializeComponent();
            if (Employee_ID!=0)
            {
                LoadInfo(Employee_ID);
            }
        }
        private void LoadInfo(Int32 EmpID)
        {
            emp.FindbyPK(EmpID.ToString());
            tbxUserName.Text = emp.UserName;
            tbxName.Text = emp.Name;
            tbxDuty.Text = emp.Duty;
            tbxIdentityCard.Text = emp.IdentityCard;
            tbxAddress.Text = emp.Address;
            tbxPhone.Text = emp.Phone;
            tbxEmail.Text = emp.Email;
            tbxRemark.Text = emp.Remark;
            dtpBirthDate.Value = emp.BirthDate;
            if (emp.Gender == "男")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUserInfo();
        }
        private void SaveUserInfo()
        {
            if (tbxUserName.Text.Trim()=="")
            {
                MessageBox.Show("请填写登录名！");
                return;
            }
            if (tbxName.Text.Trim() == "")
            {
                MessageBox.Show("请填写姓名！");
                return;
            }

            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "UserName = {0}", tbxUserName.Text });
            if (emp.GetDataSetCount("SELECT ID FROM Employee", liWhere) > 0)
            {
                MessageBox.Show("该登录名已经存在！");
                return;
            }
            emp.UserName = tbxUserName.Text;
            emp.Name = tbxName.Text;
            emp.Duty = tbxDuty.Text;
            emp.IdentityCard = tbxIdentityCard.Text;
            emp.Address = tbxAddress.Text;
            emp.Phone = tbxPhone.Text;
            emp.Email = tbxEmail.Text;
            emp.Remark = tbxRemark.Text;
            emp.BirthDate = dtpBirthDate.Value;
            if (rbMale.Checked)
            {
                emp.Gender = "男";
            }
            else
            {
                emp.Gender = "女";
            }
            if (emp.Employee_ID == 0)
            {
                emp.PassWord = DecryptEncrypt.EncryptText("111111");
                emp.Dept_ID = 1;
                emp.LastLogin = DateTime.Now;
                emp.HireDate = DateTime.Now;
                emp.Insert();
            }
            else
            {
                emp.Update();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
