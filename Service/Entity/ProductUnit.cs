using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// ProductUnit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("ProductUnit")]
    public partial class ProductUnit : EntityBase<ProductUnit>
	{
		public ProductUnit()
		{}
		#region Model
		private int _productunit_id;
		private string _name;
		private int _employee_id;
		private DateTime _createdate= DateTime.Now;
		private string _remark;
		/// <summary>
		/// 
        /// </summary>
        [PrimaryKey("ProductUnit_ID", IsAuto = true)]
		public int ProductUnit_ID
		{
			set{ _productunit_id=value;}
			get{return _productunit_id;}
		}
		/// <summary>
		/// 单位名称
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
		/// 创建时间
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

