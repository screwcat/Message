using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// Sale_Detail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("Sale_Detail")]
    public partial class Sale_Detail : EntityBase<Sale_Detail>
	{
		public Sale_Detail()
		{}
		#region Model
        private int _sale_detail_ID_id;
		private int _product_id;
		private int _saleorder_id;
		private decimal _quantity;
		private decimal _price;
        private decimal _discount;
        private int _employee_id;
        private DateTime sale_Dtl_Time;

        
		/// <summary>
		/// 
		/// </summary>
        [PrimaryKey("Sale_Detail_ID", IsAuto = true)]
        public int Sale_Detail_ID
		{
            set { _sale_detail_ID_id = value; }
            get { return _sale_detail_ID_id; }
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int Product_ID
		{
			set{ _product_id=value;}
			get{return _product_id;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int SaleOrder_ID
		{
			set{ _saleorder_id=value;}
			get{return _saleorder_id;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public decimal Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
        public decimal Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
        /// <summary>
        /// 
        /// </summary>
        [Property]
        public int Employee_ID
        {
            set { _employee_id = value; }
            get { return _employee_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        [Property]
        public DateTime Sale_Dtl_Time
        {
            get { return sale_Dtl_Time; }
            set { sale_Dtl_Time = value; }
        }
		#endregion Model

	}

    public class SaleDtlInfo
    {
        public SaleDtlInfo()
        {}
        Int32 proID;
        string proCode;
        string proName;
        decimal paidIn;
        decimal price;
        decimal quanity;
        decimal discount;
        decimal total;
        Int32 serverID;
        string server;
        DateTime sale_Dtl_Time;

        /// <summary>
        /// 商品ID
        /// </summary>
        public Int32 ProID
        {
            get { return proID; }
            set { proID = value; }
        }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProCode
        {
            get { return proCode; }
            set { proCode = value; }
        }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProName
        {
            get { return proName; }
            set { proName = value; }
        }
        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal PaidIn
        {
            get { return paidIn; }
            set { paidIn = value; }
        }
        /// <summary>
        /// 商品原价
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quanity
        {
            get { return quanity; }
            set { quanity = value; }
        }
        /// <summary>
        /// 折扣幅度
        /// </summary>
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        /// <summary>
        /// 共计金额
        /// </summary>
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        /// <summary>
        /// 服务人员ID
        /// </summary>
        public Int32 ServerID
        {
            get { return serverID; }
            set { serverID = value; }
        }
        /// <summary>
        /// 服务人员姓名
        /// </summary>
        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime Sale_Dtl_Time
        {
            get { return sale_Dtl_Time; }
            set { sale_Dtl_Time = value; }
        }
    }
}

