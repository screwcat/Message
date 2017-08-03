using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// ConsumptionRecords:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("ConsumptionRecords")]
    public partial class ConsumptionRecords : EntityBase<ConsumptionRecords>
	{
		public ConsumptionRecords()
		{}
		#region Model
		private int _id;
		private int _cardid;
		private int _rectype;
		private decimal _amount;
		private DateTime _opetime;
		private string _tradeno;
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
		public int CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 消费类型  0：消费，1：充值
        /// </summary>
        [Property]
		public int RecType
		{
			set{ _rectype=value;}
			get{return _rectype;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public decimal Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public DateTime OpeTime
		{
			set{ _opetime=value;}
			get{return _opetime;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public string TradeNo
		{
			set{ _tradeno=value;}
			get{return _tradeno;}
		}
		#endregion Model

	}
}

