﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusWCF
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bus_Details")]
	public partial class Bus_DetailsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertREGISTER(REGISTER instance);
    partial void UpdateREGISTER(REGISTER instance);
    partial void DeleteREGISTER(REGISTER instance);
    partial void InsertMONEY_TRANSACTION(MONEY_TRANSACTION instance);
    partial void UpdateMONEY_TRANSACTION(MONEY_TRANSACTION instance);
    partial void DeleteMONEY_TRANSACTION(MONEY_TRANSACTION instance);
    #endregion
		
		public Bus_DetailsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Bus_DetailsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Bus_DetailsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bus_DetailsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bus_DetailsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bus_DetailsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bus_Route> Bus_Routes
		{
			get
			{
				return this.GetTable<Bus_Route>();
			}
		}
		
		public System.Data.Linq.Table<REGISTER> REGISTERs
		{
			get
			{
				return this.GetTable<REGISTER>();
			}
		}
		
		public System.Data.Linq.Table<MONEY_TRANSACTION> MONEY_TRANSACTIONs
		{
			get
			{
				return this.GetTable<MONEY_TRANSACTION>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_UpdateDetailsTransaction")]
		public int usp_UpdateDetailsTransaction([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> money, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] ref string result)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), money, email, result);
			result = ((string)(result1.GetParameterValue(2)));
			return ((int)(result1.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bus_Route")]
	public partial class Bus_Route
	{
		
		private string _Bus_No;
		
		private string _Distance;
		
		private string _Source;
		
		private string _Destination;
		
		private string _Map_Path;
		
		private string _Map_Print;
		
		private string _Duration;
		
		private string _Rush;
		
		public Bus_Route()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bus_No", DbType="NVarChar(255)")]
		public string Bus_No
		{
			get
			{
				return this._Bus_No;
			}
			set
			{
				if ((this._Bus_No != value))
				{
					this._Bus_No = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distance", DbType="NVarChar(255)")]
		public string Distance
		{
			get
			{
				return this._Distance;
			}
			set
			{
				if ((this._Distance != value))
				{
					this._Distance = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source", DbType="NVarChar(255)")]
		public string Source
		{
			get
			{
				return this._Source;
			}
			set
			{
				if ((this._Source != value))
				{
					this._Source = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Destination", DbType="NVarChar(255)")]
		public string Destination
		{
			get
			{
				return this._Destination;
			}
			set
			{
				if ((this._Destination != value))
				{
					this._Destination = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Map_Path", DbType="NVarChar(255)")]
		public string Map_Path
		{
			get
			{
				return this._Map_Path;
			}
			set
			{
				if ((this._Map_Path != value))
				{
					this._Map_Path = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Map_Print", DbType="NVarChar(255)")]
		public string Map_Print
		{
			get
			{
				return this._Map_Print;
			}
			set
			{
				if ((this._Map_Print != value))
				{
					this._Map_Print = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="NVarChar(255)")]
		public string Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this._Duration = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rush", CanBeNull=false)]
		public string Rush
		{
			get
			{
				return this._Rush;
			}
			set
			{
				if ((this._Rush != value))
				{
					this._Rush = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.REGISTER")]
	public partial class REGISTER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Email_ID;
		
		private string _Name;
		
		private string _Password;
		
		private string _Phone_Number;
		
		private System.Nullable<int> _Bus_Money;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmail_IDChanging(string value);
    partial void OnEmail_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnPhone_NumberChanging(string value);
    partial void OnPhone_NumberChanged();
    partial void OnBus_MoneyChanging(System.Nullable<int> value);
    partial void OnBus_MoneyChanged();
    #endregion
		
		public REGISTER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_ID", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Email_ID
		{
			get
			{
				return this._Email_ID;
			}
			set
			{
				if ((this._Email_ID != value))
				{
					this.OnEmail_IDChanging(value);
					this.SendPropertyChanging();
					this._Email_ID = value;
					this.SendPropertyChanged("Email_ID");
					this.OnEmail_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(MAX)")]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this.OnPhone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Phone_Number = value;
					this.SendPropertyChanged("Phone_Number");
					this.OnPhone_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bus_Money", DbType="Int")]
		public System.Nullable<int> Bus_Money
		{
			get
			{
				return this._Bus_Money;
			}
			set
			{
				if ((this._Bus_Money != value))
				{
					this.OnBus_MoneyChanging(value);
					this.SendPropertyChanging();
					this._Bus_Money = value;
					this.SendPropertyChanged("Bus_Money");
					this.OnBus_MoneyChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MONEY_TRANSACTION")]
	public partial class MONEY_TRANSACTION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Email;
		
		private string _Name;
		
		private string _Card_Type;
		
		private string _Card_Nr;
		
		private string _BankName;
		
		private System.Nullable<int> _CVV;
		
		private System.Nullable<int> _Month;
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<int> _Amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCard_TypeChanging(string value);
    partial void OnCard_TypeChanged();
    partial void OnCard_NrChanging(string value);
    partial void OnCard_NrChanged();
    partial void OnBankNameChanging(string value);
    partial void OnBankNameChanged();
    partial void OnCVVChanging(System.Nullable<int> value);
    partial void OnCVVChanged();
    partial void OnMonthChanging(System.Nullable<int> value);
    partial void OnMonthChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    #endregion
		
		public MONEY_TRANSACTION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Card_Type", DbType="VarChar(50)")]
		public string Card_Type
		{
			get
			{
				return this._Card_Type;
			}
			set
			{
				if ((this._Card_Type != value))
				{
					this.OnCard_TypeChanging(value);
					this.SendPropertyChanging();
					this._Card_Type = value;
					this.SendPropertyChanged("Card_Type");
					this.OnCard_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Card_Nr", DbType="VarChar(50)")]
		public string Card_Nr
		{
			get
			{
				return this._Card_Nr;
			}
			set
			{
				if ((this._Card_Nr != value))
				{
					this.OnCard_NrChanging(value);
					this.SendPropertyChanging();
					this._Card_Nr = value;
					this.SendPropertyChanged("Card_Nr");
					this.OnCard_NrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankName", DbType="VarChar(50)")]
		public string BankName
		{
			get
			{
				return this._BankName;
			}
			set
			{
				if ((this._BankName != value))
				{
					this.OnBankNameChanging(value);
					this.SendPropertyChanging();
					this._BankName = value;
					this.SendPropertyChanged("BankName");
					this.OnBankNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CVV", DbType="Int")]
		public System.Nullable<int> CVV
		{
			get
			{
				return this._CVV;
			}
			set
			{
				if ((this._CVV != value))
				{
					this.OnCVVChanging(value);
					this.SendPropertyChanging();
					this._CVV = value;
					this.SendPropertyChanged("CVV");
					this.OnCVVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int")]
		public System.Nullable<int> Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
