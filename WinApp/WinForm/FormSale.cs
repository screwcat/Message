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
using Service.Common.Log;
using Service.Common;
using Service.Common.Data;

namespace WinApp.WinForm
{
    public partial class FormSale : Form
    {
        Form ParentForm1;
        Sale SaleInfo = new Sale();
        Sale_Detail SaleDtl = new Sale_Detail();
        bool IsChanged = false;
        Int32 FrmSaleID;
        public FormSale(Form parentForm, Int32 SaleID)
        {
            InitializeComponent();
            FrmSaleID = SaleID;
            dataGridView1.AutoGenerateColumns = false;
            ParentForm1 = parentForm;
            LoadInfo(SaleID);
        }

        private void FormSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChanged)
            {
                DialogResult confirm = MessageBox.Show("是否保存对此单信息的更改？", "表单内容已更改", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (confirm == DialogResult.Yes)
                {
                    if (CustIsExists())
                    {
                        e.Cancel = true;
                        return;
                    }
                    SaveInfo();
                    ParentForm1.Show();
                }
                else if (confirm == DialogResult.No)
                {
                    ParentForm1.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                ParentForm1.Show();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormSelect fs1 = new FormSelect();
            if (fs1.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = (DataTable)(dataGridView1.DataSource);
                DataRow dr = dt.NewRow();
                dr["Product_ID"] = fs1.SaleInfo.ProID;
                dr["Code"] = fs1.SaleInfo.ProCode;
                dr["ProductName"] = fs1.SaleInfo.ProName;
                dr["Price"] = fs1.SaleInfo.Price;
                dr["Quantity"] = fs1.SaleInfo.Quanity;
                dr["Discount"] = fs1.SaleInfo.Discount;
                dr["PaidIn1"] = fs1.SaleInfo.PaidIn;
                dr["PaidInAmount"] = fs1.SaleInfo.PaidIn;
                dr["Name"] = fs1.SaleInfo.Server;
                dr["Employee_ID"] = fs1.SaleInfo.ServerID;
                dr["Sale_Dtl_Time"] = fs1.SaleInfo.Sale_Dtl_Time;
                dt.Rows.Add(dr);//显示的内容
                IsChanged = true;
            }
        }

        private void LoadInfo(Int32 SaleID)
        {

            //DataGridViewComboBoxColumn dgvComboBoxColumn = dataGridView1.Columns["Discount"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn dgvComboBoxColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["Discount"];
            dgvComboBoxColumn.DataPropertyName = "Discount";
            dgvComboBoxColumn.DataSource = ExecuteSql.ExeComSqlForDataSet("SELECT DiscountRate,DisName FROM Discount WHERE Available = 1").Tables[0];
            dgvComboBoxColumn.DisplayMember = "DisName";
            dgvComboBoxColumn.ValueMember = "DiscountRate";

            string strSql = "SELECT Sale_Detail_ID,Product_ID,Code,ProductName,Price,Quantity,Discount,0.0 AS PaidIn1,0.0 AS PaidInAmount,Total,Name,Employee_ID,Sale_Dtl_Time FROM v_SaleDetailList";
            if (SaleID != 0)
            {
                this.Text = SaleID.ToString();
                SaleInfo.FindbyPK(SaleID.ToString());
                lbTradeNo.Text = SaleInfo.TradeNo;
                tbxOrderNo.Text = SaleInfo.OrderNo;
                tbxCustomer.Text = SaleInfo.Customer.ToString();
                tbxCustomer.ReadOnly = true;
                tbxStoreHouse_ID.Text = SaleInfo.StoreHouse_ID.ToString();
                lbSaleDate.Text = SaleInfo.SaleDate.ToString("yyyy-MM-dd HH:mm:ss");

                List<string[]> where = new List<string[]>();
                List<string[]> order = new List<string[]>();
                where.Add(new string[] { "SaleOrder_ID = {0}", SaleID.ToString() });
                order.Add(new string[] { "Sale_Detail_ID", "ASC" });
                DataTable dt = SaleInfo.GetDataSet(strSql, where, order);
                dataGridView1.DataSource = dt;
            }
            else
            {
                List<string[]> where = new List<string[]>();
                where.Add(new string[] { "SaleOrder_ID = {0}", SaleID.ToString() });
                DataTable dt = SaleInfo.GetDataSet(strSql, where);
                dataGridView1.DataSource = dt;
            }
            ((DataTable)dataGridView1.DataSource).Columns["PaidInAmount"].Expression = "Convert(Price*Quantity*Discount, 'System.Decimal')";
            ((DataTable)dataGridView1.DataSource).Columns["PaidIn1"].Expression = "Convert(Price*Discount, 'System.Decimal')";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CustIsExists())
            {
                return;
            }
            SaveInfo();
            Close();
            ParentForm1.Show();

        }

        private void SaveInfo()
        {
            if (FrmSaleID == 0)
            {
                SaleInfo.SaleDate = DateTime.Now;
                SaleInfo.TradeNo = SaleInfo.getTradCode();
                SaleInfo.OrderNo = tbxOrderNo.Text.Trim();
                SaleInfo.Dept_ID = 1;
                SaleInfo.Employee_ID = Convert.ToInt32(Thread.CurrentPrincipal.Identity.Name);
                SaleInfo.StoreHouse_ID = Convert.ToInt32(tbxStoreHouse_ID.Text);
                SaleInfo.Address = "沈阳市皇姑区歧山中路49号";
                SaleInfo.Account = "0000";
                SaleInfo.GatheringWay = "";
                SaleInfo.Customer = Convert.ToInt32(tbxCustomer.Text);
                SaleInfo.TotalAmount = Convert.ToDecimal(lbTotal.Text);
                SaleInfo.CheckoutTime = DateTime.Now;
                ReturnMessage rm = SaleInfo.Insert();
                lbTradeNo.Text = SaleInfo.TradeNo;
                if (rm.IsSucessed)
                {
                    FrmSaleID = Convert.ToInt32(rm.Message);
                    SaleInfo.FindbyPK(FrmSaleID.ToString());
                }
                else
                {
                    MessageBox.Show("保存失败，" + rm.Message);
                    return;
                }
            }
            else
            {
                SaleInfo.StoreHouse_ID = Convert.ToInt32(tbxStoreHouse_ID.Text);
                SaleInfo.Customer = Convert.ToInt32(tbxCustomer.Text);
                SaleInfo.TotalAmount = Convert.ToDecimal(lbTotal.Text);
                SaleInfo.Update();
            }
            DataTable gvTable = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < gvTable.Rows.Count; i++)
            {
                SaleDtl = new Sale_Detail();
                SaleDtl.Product_ID = Convert.ToInt32(gvTable.Rows[i]["Product_ID"]);
                SaleDtl.SaleOrder_ID = FrmSaleID;
                SaleDtl.Quantity = Convert.ToDecimal(gvTable.Rows[i]["Quantity"]);
                SaleDtl.Price = Convert.ToDecimal(gvTable.Rows[i]["PaidIn1"]);
                SaleDtl.Discount = Convert.ToDecimal(gvTable.Rows[i]["Discount"]);
                SaleDtl.Employee_ID = Convert.ToInt32(gvTable.Rows[i]["Employee_ID"]);
                SaleDtl.Sale_Dtl_Time = Convert.ToDateTime(gvTable.Rows[i]["Sale_Dtl_Time"]);
                if (gvTable.Rows[i]["Sale_Detail_ID"].ToString() == "")
                {
                    SaleDtl.Insert();
                }
                else
                {
                    SaleDtl.Sale_Detail_ID = Convert.ToInt32(gvTable.Rows[i]["Sale_Detail_ID"]);
                    SaleDtl.Update();
                }
            }
            IsChanged = false;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= dataGridView1.FirstDisplayedScrollingRowIndex)
            {
                using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
                {
                    int linen = 0;
                    linen = e.RowIndex + 1;
                    string line = linen.ToString();
                    e.Graphics.DrawString(line, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X, e.RowBounds.Location.Y + 5);
                    SolidBrush B = new SolidBrush(Color.Red);
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StatisticsAmount();
        }

        private void StatisticsAmount()
        {
            decimal TotalAmount = 0;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TotalAmount += Convert.ToDecimal(dt.Rows[i]["PaidInAmount"]);
            }
            lbTotal.Text = Math.Floor(Convert.ToDouble(TotalAmount) + 0.5).ToString("f2");
        }

        private void tbxCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigital(e);
        }

        private void tbxStoreHouse_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigital(e);
        }


        private void tbxCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            IsChanged = true;
        }

        private void tbxStoreHouse_ID_KeyUp(object sender, KeyEventArgs e)
        {
            IsChanged = true;
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            if (CustIsExists())
            {
                return;
            }
            SaveInfo();
            FormCashier frmCashier = new FormCashier(FrmSaleID);
            ReturnMessage rm;
            if (frmCashier.ShowDialog() == DialogResult.OK)
            {
                SaleInfo.TotalAmount = frmCashier.PaymentInfo.TotalAmount;
                SaleInfo.Cash = frmCashier.PaymentInfo.Cash;
                SaleInfo.UnionPay = frmCashier.PaymentInfo.UnionPay;
                SaleInfo.OtherPayment = frmCashier.PaymentInfo.OtherPayment;
                SaleInfo.Account = frmCashier.PaymentInfo.Account;
                SaleInfo.MemCard = frmCashier.PaymentInfo.MemCard;
                SaleInfo.CheckoutTime = DateTime.Now;
                SaleInfo.State = 0;
                rm = SaleInfo.Update();
                if (rm.IsSucessed)
                {
                    if (frmCashier.PaymentInfo.MemCard >= 0 && frmCashier.PaymentInfo.Account != "0000")
                    {
                        rm = MemCardOper.MemCardHandle(frmCashier.PaymentInfo.Account, frmCashier.PaymentInfo.MemCard, SaleInfo.TradeNo);
                        if (!rm.IsSucessed)
                        {
                            MessageBox.Show(rm.Message);
                            SaleInfo.State = 1;
                            SaleInfo.Update();//会员卡操作失败，回滚
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("结帐失败！" + rm.Message);
                    return;
                }
                string msg = "";
                if (frmCashier.PaymentInfo.Cash > 0)
                {
                    msg += "现金：" + frmCashier.PaymentInfo.Cash + "元\r";
                }
                if (frmCashier.PaymentInfo.UnionPay > 0)
                {
                    msg += "银联卡支付：" + frmCashier.PaymentInfo.UnionPay + "元\r";
                }
                if (frmCashier.PaymentInfo.MemCard > 0)
                {
                    msg += "会员卡支付：" + frmCashier.PaymentInfo.MemCard + "元\r";
                }
                if (frmCashier.PaymentInfo.OtherPayment > 0)
                {
                    msg += "其他方式支付：" + frmCashier.PaymentInfo.OtherPayment + "元\r";
                }
                if (msg != "")
                {
                    msg = "，其中\r" + msg;
                }
                /************************************************************************************/
                //打印代码放这
                PrintInfo();
                /*************************************************************************************/
                MessageBox.Show("结帐成功！\r 共消费" + frmCashier.PaymentInfo.TotalAmount + "元" + msg);
                Close();
                ParentForm1.Show();

            }
        }

        private void btnMergeBill_Click(object sender, EventArgs e)
        {
            if (CustIsExists())
            {
                return;
            }
            SaveInfo();
            FormMergeBill fmb = new FormMergeBill(FrmSaleID);
            if (fmb.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("合并成功！");
                LoadInfo(FrmSaleID);
                StatisticsAmount();
            }
        }


        private bool CustIsExists()
        {
            if (tbxCustomer.Text.Trim() == "")
            {
                MessageBox.Show("请填写客户号！");
                tbxCustomer.Focus();
                return true;
            }
            if (tbxStoreHouse_ID.Text.Trim() == "")
            {
                MessageBox.Show("请填写房间号！");
                tbxStoreHouse_ID.Focus();
                return true;
            }
            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "Customer = {0}", tbxCustomer.Text.Trim() });
            liWhere.Add(new string[] { "State = {0}", "1" });
            liWhere.Add(new string[] { "Sale_ID <> {0}", FrmSaleID.ToString() });
            Int32 CusCount = SaleInfo.GetDataSetCount("SELECT Sale_ID FROM Sale", liWhere);
            DataTable dt = SaleInfo.GetDataSet("SELECT Sale_ID FROM Sale", liWhere);
            if (CusCount > 0)
            {
                MessageBox.Show("该顾客号码当前还未结帐！");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void PrintInfo()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(((DataTable)dataGridView1.DataSource).Copy());
            PrintCommon pc = new PrintCommon();
            pc.PrintDataSet(ds, SaleInfo);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.OwningColumn.Name == "Discount")
            {
                ((ComboBox)e.Control).SelectionChangeCommitted += new EventHandler(FormSale_SelectedIndexChanged);
            }
        }

        void FormSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            dt.Rows[dataGridView1.CurrentCell.RowIndex]["Discount"] = ((ComboBox)sender).SelectedValue;
            IsChanged = true;
        }
    }
}
