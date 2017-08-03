using System;
using Service.Common.Entity;
namespace Message.Model
{
    /// <summary>
    /// ShiftInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [TableAttribute("ShiftInfo")]
    public partial class ShiftInfo : EntityBase<ShiftInfo>
	{
		public ShiftInfo()
		{}
		#region Model
		private int _id;
		private int _startid;
		private int _endid;
		private DateTime _starttime;
		private DateTime _endtime;
		private int _shiftuser;
        private DateTime _shiftTime;

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
		public int StartID
		{
			set{ _startid=value;}
			get{return _startid;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int EndID
		{
			set{ _endid=value;}
			get{return _endid;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public DateTime StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public DateTime EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int ShiftUser
		{
			set{ _shiftuser=value;}
			get{return _shiftuser;}
		}
        /// <summary>
        /// 交班时间
        /// </summary>
        [Property]
        public DateTime ShiftTime
        {
            get { return _shiftTime; }
            set { _shiftTime = value; }
        }
		#endregion Model

	}
}

