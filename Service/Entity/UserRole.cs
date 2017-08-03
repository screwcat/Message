using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// UserRole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("UserRole")]
    public partial class UserRole : EntityBase<UserRole>
	{
		public UserRole()
		{}
		#region Model
		private int _roleid;
		private int _rights;
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public int RoleId
		{
            set { _roleid = value; }
            get { return _roleid; }
		}
		/// <summary>
		/// 
        /// </summary>
        [Property]
		public int Rights
		{
			set{ _rights=value;}
			get{return _rights;}
		}
		#endregion Model

	}
}

