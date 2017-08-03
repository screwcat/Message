using System;
using Service.Common.Entity;
namespace Message.Model
{
	/// <summary>
	/// Employee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [TableAttribute("Employee")]
    public partial class Employee : EntityBase<Employee>
	{
		public Employee()
		{}
		#region Model
        private Int32 _employee_id;
		private string _username;
		private string _password;
		private int _dept_id;
		private string _name;
		private string _duty;
		private string _gender;
		private DateTime _birthdate;
		private DateTime _hiredate;
        private DateTime _lastlogin;
		private string _identitycard;
		private string _address;
		private string _phone;
		private string _email;
        private string _remark;
		/// <summary>
		/// 
		/// </summary>
        [PrimaryKey("Employee_ID", IsAuto = true)]
        public Int32 Employee_ID
		{
			set{ _employee_id=value;}
			get{return _employee_id;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public int Dept_ID
		{
			set{ _dept_id=value;}
			get{return _dept_id;}
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
        public string Duty
		{
			set{ _duty=value;}
			get{return _duty;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string Gender
		{
			set{ _gender=value;}
			get{return _gender;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public DateTime BirthDate
		{
			set{ _birthdate=value;}
			get{return _birthdate;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public DateTime HireDate
		{
			set{ _hiredate=value;}
			get{return _hiredate;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public DateTime LastLogin
		{
            set { _lastlogin = value; }
            get { return _lastlogin; }
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string IdentityCard
		{
			set{ _identitycard=value;}
			get{return _identitycard;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
        [Property]
        public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
        /// <summary>
        /// 
        /// </summary>
        [Property]
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
		#endregion Model

	}
}

