using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// ProductSpec:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("ProductSpec")]
    public partial class ProductSpec : EntityBase<ProductSpec>
	{
		public ProductSpec()
		{}
		#region Model
		private int _productspec_id;
		private string _name;
		private int _employee_id;
		private DateTime _createdate= DateTime.Now;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
        [PrimaryKey("ProductSpec_ID", IsAuto = true)]
		public int ProductSpec_ID
		{
			set{ _productspec_id=value;}
			get{return _productspec_id;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int Employee_ID
		{
			set{ _employee_id=value;}
			get{return _employee_id;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
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

