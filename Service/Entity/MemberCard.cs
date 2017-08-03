using System;
using Service.Common.Entity;
using Service.Common.Log;
using System.Collections.Generic;
using System.Data;
namespace Message.Model
{
	/// <summary>
	/// MemberCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("MemberCard")]
    public partial class MemberCard : EntityBase<MemberCard>
	{
		public MemberCard()
		{}
		#region Model
		private int _id;
		private string _cardno;
		private int _cardtype;
		private string _membername;
		private string _password;
		private string _usertel;
		private string _userpic;
		private decimal _balance;
		private DateTime _handletime= DateTime.Now;
		private DateTime _lastuse= DateTime.Now;
		private int _state;
		private string _remarks;
		/// <summary>
		/// ID
		/// </summary>
        [PrimaryKey("ID", IsAuto = true)]
        public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 会员卡号
        /// </summary>
        [Property]
		public string CardNO
		{
			set{ _cardno=value;}
			get{return _cardno;}
		}
		/// <summary>
		/// 会员卡类型
        /// </summary>
        [Property]
		public int CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 用户姓名
        /// </summary>
        [Property]
		public string MemberName
		{
			set{ _membername=value;}
			get{return _membername;}
		}
		/// <summary>
		/// 密码
        /// </summary>
        [Property]
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 联系电话
        /// </summary>
        [Property]
		public string UserTel
		{
			set{ _usertel=value;}
			get{return _usertel;}
		}
		/// <summary>
		/// 照片
        /// </summary>
        [Property]
		public string UserPic
		{
			set{ _userpic=value;}
			get{return _userpic;}
		}
		/// <summary>
		/// 余额
        /// </summary>
        [Property]
		public decimal Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 办理时间
        /// </summary>
        [Property]
		public DateTime HandleTime
		{
			set{ _handletime=value;}
			get{return _handletime;}
		}
		/// <summary>
		/// 最后一次使用
        /// </summary>
        [Property]
		public DateTime LastUse
		{
			set{ _lastuse=value;}
			get{return _lastuse;}
		}
		/// <summary>
		/// 状态 1：可用，0：不可用
        /// </summary>
        [Property]
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 备注
        /// </summary>
        [Property]
		public string Remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		#endregion Model

	}

    public static class MemCardOper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CardNumber">会员卡号</param>
        /// <param name="ConsumptionAmount">消费金额</param>
        /// <param name="TradeNo">交易号</param>
        /// <returns></returns>
        public static ReturnMessage MemCardHandle(string CardNumber, decimal ConsumptionAmount, string TradeNo)
        {
            ReturnMessage rm = new ReturnMessage();
            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "CardNO = {0}", CardNumber });
            MemberCard mc = new MemberCard();
            DataTable dt = mc.GetDataSet("SELECT TOP 1 ID FROM MemberCard", liWhere);
            string MbID;
            if (dt.Rows.Count > 0)
            {
                MbID = dt.Rows[0][0].ToString();
                mc.FindbyPK(MbID);
                mc.Balance -= ConsumptionAmount;
                mc.LastUse = DateTime.Now;
                rm = mc.Update();

                if (!rm.IsSucessed)
                {
                    rm.Message += "更新会员卡信息出错！";
                    return rm;
                }
                else
                {
                    ConsumptionRecords cr = new ConsumptionRecords();
                    cr.CardID = mc.ID;
                    cr.RecType = 0;
                    cr.Amount = ConsumptionAmount;
                    cr.TradeNo = TradeNo;
                    cr.OpeTime = DateTime.Now;
                    cr.Insert();
                    return rm;
                }
            }
            else
            {
                rm.IsSucessed = false;
                rm.Message = "读取会员卡信息出错！";
                return rm;
            }
        }
    }
}

