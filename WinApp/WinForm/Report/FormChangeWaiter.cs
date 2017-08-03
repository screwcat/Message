using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.Common;
using Message.Model;

namespace WinApp.WinForm.Report
{
    public partial class FormChangeWaiter : Form
    {
        Sale_Detail DetailInfo = new Sale_Detail();
        public FormChangeWaiter(Int32 Sale_Detail_ID)
        {
            InitializeComponent();
            ControlCommon.BindEmployee(cbWaiter);

            DetailInfo.FindbyPK(Sale_Detail_ID.ToString());
            cbWaiter.SelectedValue = DetailInfo.Employee_ID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DetailInfo.Employee_ID = Convert.ToInt32(cbWaiter.SelectedValue);
            DetailInfo.Update();
            DialogResult = DialogResult.OK;
        }
    }
}
