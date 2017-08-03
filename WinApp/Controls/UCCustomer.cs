using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinApp.Controls
{
    public delegate void EventEntrust(object sender, Int32 e);
    public partial class UCCustomer : UserControl
    {
        public event EventEntrust MyEvent;
        private Int32 saleID;
        private string custemerNo;
        private string storeHouse_ID;
        private string employee_ID;
        private DateTime saleDate;

        public Int32 SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }
        public string CustemerNo
        {
            get { return custemerNo; }
            set { custemerNo = value; }
        }

        public string StoreHouse_ID
        {
            get { return storeHouse_ID; }
            set { storeHouse_ID = value; }
        }

        public string Employee_ID
        {
            get { return employee_ID; }
            set { employee_ID = value; }
        }

        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }

        public UCCustomer()
        {
            InitializeComponent();
        }


        private void UCCustomer_Load(object sender, EventArgs e)
        {
            this.lbCustomer.Text = custemerNo;
            this.lbRoom.Text = storeHouse_ID;
            this.lbOperater.Text = employee_ID;
            this.lbSaleTime.Text = saleDate.ToString("yyyy-MM-dd HH:mm:ss");
        }



        private void UCCustomer_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void UCCustomer_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void UCCustomer_Click(object sender, EventArgs e)
        {
            MyEvent(this, SaleID);
        }

        private void lbCustomer_Click(object sender, EventArgs e)
        {
            MyEvent(this, SaleID);
        }

        private void lbCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbCustomer_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.BorderStyle = BorderStyle.FixedSingle;
        }



    }
}
