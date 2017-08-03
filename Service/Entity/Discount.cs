using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// Discount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("Discount")]
    public partial class Discount : EntityBase<Discount>
	{
		public Discount()
		{}
		#region Model
		private int _id;
		private decimal _discountrate;
		private string _disname;
		private bool _available;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
        [PrimaryKey("ID", IsAuto = true)]
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
        public decimal DiscountRate
		{
			set{ _discountrate=value;}
			get{return _discountrate;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public string DisName
		{
			set{ _disname=value;}
			get{return _disname;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public bool Available
		{
			set{ _available=value;}
			get{return _available;}
		}
		/// <summary>
		/// 
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

