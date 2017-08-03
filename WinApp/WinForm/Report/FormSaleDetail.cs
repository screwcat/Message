using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.Common.DB;
using Message.Model;
using Service.Common.Log;
using Service.Common;

namespace WinApp.WinForm.Report
{
    public partial class FormSaleDetail : Form
    {
        Sale SaleInfo = new Sale();
        public FormSaleDetail(Int32 sald_id)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            LoadInfo(sald_id);
        }
        private void LoadInfo(Int32 SaleID)
        {
            SaleInfo.FindbyPK(SaleID.ToString());
            Text = SaleInfo.TradeNo;

            lbTradeNo.Text = SaleInfo.TradeNo;
            lbOrderNo.Text = SaleInfo.OrderNo;
            lbCustomer.Text = SaleInfo.Customer.ToString();
            lbStoreHouse_ID.Text = SaleInfo.StoreHouse_ID.ToString();
            lbSaleDate.Text = SaleInfo.SaleDate.ToString("yyyy年M月d日 HH:mm:ss");
            lbCheckoutTime.Text = SaleInfo.CheckoutTime.ToString("yyyy年M月d日 HH:mm:ss");
            tbxCash.Text = SaleInfo.Cash.ToString("f2");
            tbxUnionPay.Text = SaleInfo.UnionPay.ToString("f2");
            tbxMemCard.Text = SaleInfo.MemCard.ToString("f2");
            tbxOtherPayment.Text = SaleInfo.OtherPayment.ToString("f2");
            lbTotalAmount.Text = SaleInfo.TotalAmount.ToString("f2");
            if (SaleInfo.Account == "0000")
            {
                lbAccount.Text = "----";
            }
            else
            {
                lbAccount.Text = SaleInfo.Account;
            }
            ReturnMessage rm = new ReturnMessage();
            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "CardNO = {0}", SaleInfo.Account });
            MemberCard mc = new MemberCard();
            DataTable dtmc = mc.GetDataSet("SELECT TOP 1 ID FROM MemberCard", liWhere);
            string MbID;
            if (dtmc.Rows.Count > 0)
            {
                MbID = dtmc.Rows[0][0].ToString();
                mc.FindbyPK(MbID);
                lbMbName.Text = mc.MemberName;
            }
            else
            {
                lbMbName.Text = "----";
            }
            liWhere.Clear();
            Employee emp = new Employee();
            emp.FindbyPK(SaleInfo.Employee_ID.ToString());
            lbEmployeeName.Text = emp.Name;



            List<string[]> where = new List<string[]>();
            List<string[]> order = new List<string[]>();
            where.Add(new string[] { "SaleOrder_ID = {0}", SaleID.ToString() });
            order.Add(new string[] { "a.Sale_Dtl_Time", "ASC" });
            DataTable dt = SaleInfo.GetDataSet("SELECT a.Sale_Detail_ID,b.Product_ID,b.Code,b.Name AS ProductName,convert(numeric(18,2),a.Price) AS PaidIn1,convert(numeric(18,2),b.Price) AS Price,convert(numeric(18,2),a.Quantity) AS Quantity,convert(numeric(18,2),a.Price/b.Price) AS Discount, convert(numeric(18,2),a.Price*a.Quantity) AS PaidInAmount,a.Employee_ID,c.Name AS ServerName FROM Sale_Detail a LEFT JOIN Product b ON b.Product_ID = a.Product_ID LEFT JOIN Employee c ON c.Employee_ID = a.Employee_ID", where, order);
            dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintAgain_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(((DataTable)dataGridView1.DataSource).Copy());
            PrintCommon pc = new PrintCommon();
            pc.PrintDataSet(ds, SaleInfo);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selectRow = dataGridView1.CurrentCell.RowIndex;
            FormChangeWaiter fcw = new FormChangeWaiter(Convert.ToInt32(dataGridView1.Rows[selectRow].Cells["Sale_Detail_ID"].Value));
            if (fcw.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("修改成功！");
                LoadInfo(SaleInfo.Sale_ID);
            }
            dataGridView1.CurrentCell = dataGridView1[0, selectRow];
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            decimal TotalAmount = Convert.ToDecimal(tbxCash.Text) + Convert.ToDecimal(tbxUnionPay.Text) + Convert.ToDecimal(tbxMemCard.Text) + Convert.ToDecimal(tbxOtherPayment.Text);
            if (TotalAmount == Convert.ToDecimal(lbTotalAmount.Text))
            {
                if (Convert.ToDecimal(tbxMemCard.Text)!=SaleInfo.MemCard)
                {
                    decimal Adjustment = Convert.ToDecimal(tbxMemCard.Text) - SaleInfo.MemCard;
                    string CardNumber = SaleInfo.Account;
                    if (CardNumber == "0000")
                    {
                        FormMemCard fmc = new FormMemCard(Adjustment);
                        if (fmc.ShowDialog() == DialogResult.OK && fmc.PaymentCard == Adjustment)
                        {
                            CardNumber = fmc.CardNo;
                        }
                        else
                        {
                            MessageBox.Show("会员卡信息操作失败，未保存！");
                            return;
                        }
                    }
                    ReturnMessage rm = new ReturnMessage();
                    rm = MemCardOper.MemCardHandle(CardNumber, Adjustment, SaleInfo.TradeNo);
                    SaleInfo.Account = CardNumber;
                    if (!rm.IsSucessed)
                    {
                        MessageBox.Show("操作失败，" + rm.Message);
                        return;
                    }
                }


                SaleInfo.Cash = Convert.ToDecimal(tbxCash.Text);
                SaleInfo.UnionPay = Convert.ToDecimal(tbxUnionPay.Text);
                SaleInfo.MemCard = Convert.ToDecimal(tbxMemCard.Text);
                SaleInfo.OtherPayment = Convert.ToDecimal(tbxOtherPayment.Text);
                SaleInfo.Update();
                MessageBox.Show("保存成功！");
                Close();
            }
            else
            {
                MessageBox.Show("金额填写不正确！");
            }
        }

        private void tbxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void tbxUnionPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void tbxMemCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }

        private void tbxOtherPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDecimal(sender, e);
        }
    }
}