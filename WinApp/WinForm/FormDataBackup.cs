using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.Common.Data;
using Service.Common.Log;

namespace WinApp.WinForm
{
    public partial class FormDataBackup : Form
    {
        ReturnMessage rm = new ReturnMessage();
        string BackPath;
        public ReturnMessage Rm
        {
            get { return rm; }
            set { rm = value; }
        }
        public FormDataBackup(string backPath)
        {
            InitializeComponent();
            BackPath = backPath;
        }

        private void FormDataBackup_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string strTime = string.Format("{0:yyyy-MM-dd@HH：mm：ss}", DateTime.Now);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("backup database Message to disk = '" + BackPath + strTime + ".bak" + "'");
            Int32 BackupNum = 0;
            try
            {
                BackupNum = ExecuteSql.ExeComSqlForNonQuery(strSql.ToString());
                rm.Message = "备份成功！";
                rm.IsSucessed = true;
            }
            catch (Exception ex)
            {
                rm.Message = "备份失败！" + ex.Message;
                rm.IsSucessed = false;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (rm.IsSucessed)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
