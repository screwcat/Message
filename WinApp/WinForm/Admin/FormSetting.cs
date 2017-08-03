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

namespace WinApp.WinForm.Admin
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FindbyPK(Thread.CurrentPrincipal.Identity.Name);
            if (tbxOriginalPwd.Text.Trim() != "")
            {
                if (DecryptEncrypt.EncryptText(tbxOriginalPwd.Text) == emp.PassWord)
                {
                    if (tbxNewPwd.Text.Trim() != "")
                    {
                        if (tbxNewPwdConfirm.Text.Trim() != "")
                        {
                            if (tbxNewPwd.Text.Trim() == tbxNewPwdConfirm.Text.Trim())
                            {
                                emp.PassWord = DecryptEncrypt.EncryptText(tbxNewPwd.Text.Trim());
                                emp.Update();
                                MessageBox.Show("密码修改成功！");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("两次新密码不一样！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("请填写确认新密码！");
                            tbxNewPwdConfirm.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请填写新密码！");
                        tbxNewPwd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("原密码不正确！");
                    tbxOriginalPwd.Focus();
                }
            }
            else
            {
                MessageBox.Show("请填写原密码！");
                tbxOriginalPwd.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
