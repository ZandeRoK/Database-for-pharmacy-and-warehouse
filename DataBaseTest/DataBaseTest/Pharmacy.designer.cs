﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseTest
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_Main")]
	public partial class PharmacyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertRoleUser(RoleUser instance);
    partial void UpdateRoleUser(RoleUser instance);
    partial void DeleteRoleUser(RoleUser instance);
    partial void InsertStatus(Status instance);
    partial void UpdateStatus(Status instance);
    partial void DeleteStatus(Status instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertWarehouse(Warehouse instance);
    partial void UpdateWarehouse(Warehouse instance);
    partial void DeleteWarehouse(Warehouse instance);
    partial void InsertStore(Store instance);
    partial void UpdateStore(Store instance);
    partial void DeleteStore(Store instance);
    #endregion
		
		public PharmacyDataContext() : 
				base(global::DataBaseTest.Properties.Settings.Default.DB_MainConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PharmacyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PharmacyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PharmacyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PharmacyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Order> Order
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<RoleUser> RoleUser
		{
			get
			{
				return this.GetTable<RoleUser>();
			}
		}
		
		public System.Data.Linq.Table<Status> Status
		{
			get
			{
				return this.GetTable<Status>();
			}
		}
		
		public System.Data.Linq.Table<User> User
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Warehouse> Warehouse
		{
			get
			{
				return this.GetTable<Warehouse>();
			}
		}
		
		public System.Data.Linq.Table<Store> Store
		{
			get
			{
				return this.GetTable<Store>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdDrug;
		
		private int _IdStatus;
		
		private int _Count;
		
		private System.DateTime _Date;
		
		private EntityRef<Status> _Status;
		
		private EntityRef<Warehouse> _Warehouse;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdDrugChanging(int value);
    partial void OnIdDrugChanged();
    partial void OnIdStatusChanging(int value);
    partial void OnIdStatusChanged();
    partial void OnCountChanging(int value);
    partial void OnCountChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Order()
		{
			this._Status = default(EntityRef<Status>);
			this._Warehouse = default(EntityRef<Warehouse>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDrug", DbType="Int NOT NULL")]
		public int IdDrug
		{
			get
			{
				return this._IdDrug;
			}
			set
			{
				if ((this._IdDrug != value))
				{
					if (this._Warehouse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDrugChanging(value);
					this.SendPropertyChanging();
					this._IdDrug = value;
					this.SendPropertyChanged("IdDrug");
					this.OnIdDrugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdStatus", DbType="Int NOT NULL")]
		public int IdStatus
		{
			get
			{
				return this._IdStatus;
			}
			set
			{
				if ((this._IdStatus != value))
				{
					if (this._Status.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdStatusChanging(value);
					this.SendPropertyChanging();
					this._IdStatus = value;
					this.SendPropertyChanged("IdStatus");
					this.OnIdStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Count", DbType="Int NOT NULL")]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				if ((this._Count != value))
				{
					this.OnCountChanging(value);
					this.SendPropertyChanging();
					this._Count = value;
					this.SendPropertyChanged("Count");
					this.OnCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Status_Order", Storage="_Status", ThisKey="IdStatus", OtherKey="Id", IsForeignKey=true)]
		public Status Status
		{
			get
			{
				return this._Status.Entity;
			}
			set
			{
				Status previousValue = this._Status.Entity;
				if (((previousValue != value) 
							|| (this._Status.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Status.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Status.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._IdStatus = value.Id;
					}
					else
					{
						this._IdStatus = default(int);
					}
					this.SendPropertyChanged("Status");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Warehouse_Order", Storage="_Warehouse", ThisKey="IdDrug", OtherKey="Id", IsForeignKey=true)]
		public Warehouse Warehouse
		{
			get
			{
				return this._Warehouse.Entity;
			}
			set
			{
				Warehouse previousValue = this._Warehouse.Entity;
				if (((previousValue != value) 
							|| (this._Warehouse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Warehouse.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Warehouse.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._IdDrug = value.Id;
					}
					else
					{
						this._IdDrug = default(int);
					}
					this.SendPropertyChanged("Warehouse");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RoleUser")]
	public partial class RoleUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _RoleName;
		
		private EntitySet<User> _User;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    #endregion
		
		public RoleUser()
		{
			this._User = new EntitySet<User>(new Action<User>(this.attach_User), new Action<User>(this.detach_User));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this.OnRoleNameChanging(value);
					this.SendPropertyChanging();
					this._RoleName = value;
					this.SendPropertyChanged("RoleName");
					this.OnRoleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoleUser_User", Storage="_User", ThisKey="Id", OtherKey="IdRole")]
		public EntitySet<User> User
		{
			get
			{
				return this._User;
			}
			set
			{
				this._User.Assign(value);
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
		
		private void attach_User(User entity)
		{
			this.SendPropertyChanging();
			entity.RoleUser = this;
		}
		
		private void detach_User(User entity)
		{
			this.SendPropertyChanging();
			entity.RoleUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Status")]
	public partial class Status : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameStatus;
		
		private EntitySet<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameStatusChanging(string value);
    partial void OnNameStatusChanged();
    #endregion
		
		public Status()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameStatus", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string NameStatus
		{
			get
			{
				return this._NameStatus;
			}
			set
			{
				if ((this._NameStatus != value))
				{
					this.OnNameStatusChanging(value);
					this.SendPropertyChanging();
					this._NameStatus = value;
					this.SendPropertyChanged("NameStatus");
					this.OnNameStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Status_Order", Storage="_Order", ThisKey="Id", OtherKey="IdStatus")]
		public EntitySet<Order> Order
		{
			get
			{
				return this._Order;
			}
			set
			{
				this._Order.Assign(value);
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
		
		private void attach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Status = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Status = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstAndLastNames;
		
		private string _Password;
		
		private int _IdRole;
		
		private string _e_mail;
		
		private string _phone;
		
		private EntityRef<RoleUser> _RoleUser;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstAndLastNamesChanging(string value);
    partial void OnFirstAndLastNamesChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnIdRoleChanging(int value);
    partial void OnIdRoleChanged();
    partial void One_mailChanging(string value);
    partial void One_mailChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    #endregion
		
		public User()
		{
			this._RoleUser = default(EntityRef<RoleUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstAndLastNames", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string FirstAndLastNames
		{
			get
			{
				return this._FirstAndLastNames;
			}
			set
			{
				if ((this._FirstAndLastNames != value))
				{
					this.OnFirstAndLastNamesChanging(value);
					this.SendPropertyChanging();
					this._FirstAndLastNames = value;
					this.SendPropertyChanged("FirstAndLastNames");
					this.OnFirstAndLastNamesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(15) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRole", DbType="Int NOT NULL")]
		public int IdRole
		{
			get
			{
				return this._IdRole;
			}
			set
			{
				if ((this._IdRole != value))
				{
					if (this._RoleUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdRoleChanging(value);
					this.SendPropertyChanging();
					this._IdRole = value;
					this.SendPropertyChanged("IdRole");
					this.OnIdRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[e-mail]", Storage="_e_mail", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string e_mail
		{
			get
			{
				return this._e_mail;
			}
			set
			{
				if ((this._e_mail != value))
				{
					this.One_mailChanging(value);
					this.SendPropertyChanging();
					this._e_mail = value;
					this.SendPropertyChanged("e_mail");
					this.One_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoleUser_User", Storage="_RoleUser", ThisKey="IdRole", OtherKey="Id", IsForeignKey=true)]
		public RoleUser RoleUser
		{
			get
			{
				return this._RoleUser.Entity;
			}
			set
			{
				RoleUser previousValue = this._RoleUser.Entity;
				if (((previousValue != value) 
							|| (this._RoleUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RoleUser.Entity = null;
						previousValue.User.Remove(this);
					}
					this._RoleUser.Entity = value;
					if ((value != null))
					{
						value.User.Add(this);
						this._IdRole = value.Id;
					}
					else
					{
						this._IdRole = default(int);
					}
					this.SendPropertyChanged("RoleUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Warehouse")]
	public partial class Warehouse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameDrug;
		
		private int _Count;
		
		private string _Description;
		
		private EntitySet<Order> _Order;
		
		private EntitySet<Store> _Store;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameDrugChanging(string value);
    partial void OnNameDrugChanged();
    partial void OnCountChanging(int value);
    partial void OnCountChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Warehouse()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			this._Store = new EntitySet<Store>(new Action<Store>(this.attach_Store), new Action<Store>(this.detach_Store));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameDrug", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NameDrug
		{
			get
			{
				return this._NameDrug;
			}
			set
			{
				if ((this._NameDrug != value))
				{
					this.OnNameDrugChanging(value);
					this.SendPropertyChanging();
					this._NameDrug = value;
					this.SendPropertyChanged("NameDrug");
					this.OnNameDrugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Count", DbType="Int NOT NULL")]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				if ((this._Count != value))
				{
					this.OnCountChanging(value);
					this.SendPropertyChanging();
					this._Count = value;
					this.SendPropertyChanged("Count");
					this.OnCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Warehouse_Order", Storage="_Order", ThisKey="Id", OtherKey="IdDrug")]
		public EntitySet<Order> Order
		{
			get
			{
				return this._Order;
			}
			set
			{
				this._Order.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Warehouse_Store", Storage="_Store", ThisKey="Id", OtherKey="IdDrug")]
		public EntitySet<Store> Store
		{
			get
			{
				return this._Store;
			}
			set
			{
				this._Store.Assign(value);
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
		
		private void attach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Warehouse = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Warehouse = null;
		}
		
		private void attach_Store(Store entity)
		{
			this.SendPropertyChanging();
			entity.Warehouse = this;
		}
		
		private void detach_Store(Store entity)
		{
			this.SendPropertyChanging();
			entity.Warehouse = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Store")]
	public partial class Store : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdDrug;
		
		private int _Count;
		
		private EntityRef<Warehouse> _Warehouse;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdDrugChanging(int value);
    partial void OnIdDrugChanged();
    partial void OnCountChanging(int value);
    partial void OnCountChanged();
    #endregion
		
		public Store()
		{
			this._Warehouse = default(EntityRef<Warehouse>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDrug", DbType="Int NOT NULL")]
		public int IdDrug
		{
			get
			{
				return this._IdDrug;
			}
			set
			{
				if ((this._IdDrug != value))
				{
					if (this._Warehouse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDrugChanging(value);
					this.SendPropertyChanging();
					this._IdDrug = value;
					this.SendPropertyChanged("IdDrug");
					this.OnIdDrugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Count", DbType="Int NOT NULL")]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				if ((this._Count != value))
				{
					this.OnCountChanging(value);
					this.SendPropertyChanging();
					this._Count = value;
					this.SendPropertyChanged("Count");
					this.OnCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Warehouse_Store", Storage="_Warehouse", ThisKey="IdDrug", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Warehouse Warehouse
		{
			get
			{
				return this._Warehouse.Entity;
			}
			set
			{
				Warehouse previousValue = this._Warehouse.Entity;
				if (((previousValue != value) 
							|| (this._Warehouse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Warehouse.Entity = null;
						previousValue.Store.Remove(this);
					}
					this._Warehouse.Entity = value;
					if ((value != null))
					{
						value.Store.Add(this);
						this._IdDrug = value.Id;
					}
					else
					{
						this._IdDrug = default(int);
					}
					this.SendPropertyChanged("Warehouse");
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
