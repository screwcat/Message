using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WinApp.WinForm
{
    public partial class FormBackPassword : Form
    {
        public FormBackPassword()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (tbxBackPwd.Text != "")
            {
                if (ConfigurationManager.AppSettings.Get("BackPwd") == tbxBackPwd.Text.Trim())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lbWrongPwd.Visible = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}