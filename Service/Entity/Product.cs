using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("Product")]
    public partial class Product : EntityBase<Product>
	{
		public Product()
		{}
		#region Model
		private int _product_id;
		private string _code;
		private int _productlist_id;
		private string _name;
		private string _shortname;
		private string _spell;
		private string _s_spell;
		private int _productspec_id;
		private int _productunit_id;
		private decimal _price;
		private decimal _offering_price;
        private decimal _commission;
		private int _employee_id;
		private DateTime _createdate= DateTime.Now;
		private string _remark;
		/// <summary>
		/// ID
		/// </summary>
        [PrimaryKey("Product_ID", IsAuto = true)]
		public int Product_ID
		{
			set{ _product_id=value;}
			get{return _product_id;}
		}
		/// <summary>
		/// 商品编号
        /// </summary>
        [Property]
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int ProductList_ID
		{
			set{ _productlist_id=value;}
			get{return _productlist_id;}
		}
		/// <summary>
		/// 商品名称
        /// </summary>
        [Property]
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 名称简写
        /// </summary>
        [Property]
		public string shortname
		{
			set{ _shortname=value;}
			get{return _shortname;}
		}
		/// <summary>
		/// 拼音全拼
        /// </summary>
        [Property]
		public string spell
		{
			set{ _spell=value;}
			get{return _spell;}
		}
		/// <summary>
		/// 拼音简写
        /// </summary>
        [Property]
		public string s_spell
		{
			set{ _s_spell=value;}
			get{return _s_spell;}
		}
		/// <summary>
		/// 部门ID
        /// </summary>
        [Property]
		public int ProductSpec_ID
		{
			set{ _productspec_id=value;}
			get{return _productspec_id;}
		}
		/// <summary>
		/// 类型ID
        /// </summary>
        [Property]
		public int ProductUnit_ID
		{
			set{ _productunit_id=value;}
			get{return _productunit_id;}
		}
		/// <summary>
		/// 价格
        /// </summary>
        [Property]
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 折扣价格
        /// </summary>
        [Property]
		public decimal Offering_Price
		{
			set{ _offering_price=value;}
			get{return _offering_price;}
		}

        /// <summary>
        /// 提成
        /// </summary>
        [Property]
        public decimal Commission
        {
            get { return _commission; }
            set { _commission = value; }
        }
		/// <summary>
		/// 操作员
        /// </summary>
        [Property]
		public int Employee_ID
		{
			set{ _employee_id=value;}
			get{return _employee_id;}
		}
		/// <summary>
		/// 创建日期
        /// </summary>
        [Property]
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 备注
        /// </summary>
        [Property]
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

