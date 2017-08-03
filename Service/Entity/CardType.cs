using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// CardType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("CardType")]
    public partial class CardType : EntityBase<CardType>
	{
		public CardType()
		{}
		#region Model
		private int _id;
        private int _vailable;
		private string _typename;
		private decimal _discount;
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
        public int Available
		{
            set { _vailable = value; }
            get { return _vailable; }
		}
		/// <summary>
		/// 类型名称
		/// </summary>
        [Property]
        public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 折扣
        /// </summary>
        [Property]
        public decimal Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		#endregion Model

	}
}

