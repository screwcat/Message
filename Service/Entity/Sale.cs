using System;
using Service.Common.Entity;
using System.Collections.Generic;
using System.Data;
namespace Message.Model
{
    /// <summary>
    /// Sale:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [TableAttribute("Sale")]
    public partial class Sale : EntityBase<Sale>
    {
        public Sale()
        { }
        #region Model
        private int _sale_id;
        private DateTime _saledate;
        private string _tradeno;
        private string _orderNo;
        private int _dept_id;
        private int _employee_id;
        private int _storehouse_id;
        private string _address;
        private string _account;
        private string _gatheringway;
        private int _customer;
        private decimal _totalAmount;
        private decimal _memCard;
        private decimal _cash;
        private decimal unionPay;
        private decimal _otherPayment;
        private DateTime _checkoutTime;
        private int _state = 1;
        /// <summary>
        /// 
        /// </summary>
        [PrimaryKey("Sale_ID", IsAuto = true)]
        public int Sale_ID
        {
            set { _sale_id = value; }
            get { return _sale_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime SaleDate
        {
            set { _saledate = value; }
            get { return _saledate; }
        }
        /// <summary>
        /// 单号
        /// </summary>
        [Property]
        public string TradeNo
        {
            set { _tradeno = value; }
            get { return _tradeno; }
        }
        /// <summary>
        /// 单号
        /// </summary>
        [Property]
        public string OrderNo
        {
            get { return _orderNo; }
            set { _orderNo = value; }
        }
        /// <summary>
        /// 部门ID
        /// </summary>
        [Property]
        public int Dept_ID
        {
            set { _dept_id = value; }
            get { return _dept_id; }
        }
        /// <summary>
        /// 操作员
        /// </summary>
        [Property]
        public int Employee_ID
        {
            set { _employee_id = value; }
            get { return _employee_id; }
        }
        /// <summary>
        /// 房间号
        /// </summary>
        [Property]
        public int StoreHouse_ID
        {
            set { _storehouse_id = value; }
            get { return _storehouse_id; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        [Property]
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 会员卡号
        /// </summary>
        [Property]
        public string Account
        {
            set { _account = value; }
            get { return _account; }
        }
        /// <summary>
        /// 采集方式
        /// </summary>
        [Property]
        public string GatheringWay
        {
            set { _gatheringway = value; }
            get { return _gatheringway; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        [Property]
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        /// <summary>
        /// 会员卡支付额
        /// </summary>
        [Property]
        public decimal MemCard
        {
            get { return _memCard; }
            set { _memCard = value; }
        }
        /// <summary>
        /// 现金支付额
        /// </summary>
        [Property]
        public decimal Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }
        /// <summary>
        /// 银联卡
        /// </summary>
        [Property]
        public decimal UnionPay
        {
            get { return unionPay; }
            set { unionPay = value; }
        }
        /// <summary>
        /// 其他支付方式
        /// </summary>
        [Property]
        public decimal OtherPayment
        {
            get { return _otherPayment; }
            set { _otherPayment = value; }
        }
        /// <summary>
        /// 顾客手牌号
        /// </summary>
        [Property]
        public int Customer
        {
            set { _customer = value; }
            get { return _customer; }
        }
        /// <summary>
        /// 结帐时间
        /// </summary>
        [Property]
        public DateTime CheckoutTime
        {
            get { return _checkoutTime; }
            set { _checkoutTime = value; }
        }
        /// <summary>
        /// 状态 0：已结帐，1：进行中
        /// </summary>
        [Property]
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        #endregion Model


        /// <summary>
        /// 生成单号
        /// </summary>
        /// <returns></returns>
        public string getTradCode()
        {
            List<string[]> where = new List<string[]>();
            List<string[]> order = new List<string[]>();
            string Today = DateTime.Now.ToString("yyyyMMdd");
            where.Add(new string[] { "SaleDate >= {0}", Today });
            order.Add(new string[] { "TradeNo", "DESC" });
            DataTable dt = this.GetDataSet("SELECT TradeNo FROM Sale", where, order);
            if (dt.Rows.Count > 0)
            {
                return Today + (Convert.ToInt32(dt.Rows[0][0].ToString().Substring(8, 3)) + 1).ToString("000");
            }
            else
            {
                return Today + "001";
            }
        }

    }
    public class PaymentInfo
    {
        private decimal totalAmount = 0;
        private decimal memCard = 0;
        private decimal cash = 0;
        private decimal unionPay = 0;
        private decimal otherPayment = 0;
        private string account = "0000";

        /// <summary>
        /// 全单总计金额
        /// </summary>
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        /// <summary>
        /// 会员卡支付额
        /// </summary>
        public decimal MemCard
        {
            get { return memCard; }
            set { memCard = value; }
        }
        /// <summary>
        /// 现金
        /// </summary>
        public decimal Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        /// <summary>
        /// 银联
        /// </summary>
        public decimal UnionPay
        {
            get { return unionPay; }
            set { unionPay = value; }
        }
        /// <summary>
        /// 其他支付方式
        /// </summary>
        public decimal OtherPayment
        {
            get { return otherPayment; }
            set { otherPayment = value; }
        }
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
    }
}

