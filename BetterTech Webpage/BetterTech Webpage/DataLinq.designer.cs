﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterTech_Webpage
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BetterTech_DB")]
	public partial class DataLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertWishlist(Wishlist instance);
    partial void UpdateWishlist(Wishlist instance);
    partial void DeleteWishlist(Wishlist instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataLinqDataContext() : 
				base(global::BetterTech_Webpage.Properties.Settings.Default.BetterTech_DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Wishlist> Wishlists
		{
			get
			{
				return this.GetTable<Wishlist>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Invoice_Id;
		
		private System.DateTime _Invoice_Date;
		
		private string _Username;
		
		private decimal _Invoice_Total;
		
		private EntitySet<Item> _Items;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInvoice_IdChanging(int value);
    partial void OnInvoice_IdChanged();
    partial void OnInvoice_DateChanging(System.DateTime value);
    partial void OnInvoice_DateChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnInvoice_TotalChanging(decimal value);
    partial void OnInvoice_TotalChanged();
    #endregion
		
		public Invoice()
		{
			this._Items = new EntitySet<Item>(new Action<Item>(this.attach_Items), new Action<Item>(this.detach_Items));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Invoice_Id
		{
			get
			{
				return this._Invoice_Id;
			}
			set
			{
				if ((this._Invoice_Id != value))
				{
					this.OnInvoice_IdChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Id = value;
					this.SendPropertyChanged("Invoice_Id");
					this.OnInvoice_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Invoice_Date
		{
			get
			{
				return this._Invoice_Date;
			}
			set
			{
				if ((this._Invoice_Date != value))
				{
					this.OnInvoice_DateChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Date = value;
					this.SendPropertyChanged("Invoice_Date");
					this.OnInvoice_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Total", DbType="Money NOT NULL")]
		public decimal Invoice_Total
		{
			get
			{
				return this._Invoice_Total;
			}
			set
			{
				if ((this._Invoice_Total != value))
				{
					this.OnInvoice_TotalChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Total = value;
					this.SendPropertyChanged("Invoice_Total");
					this.OnInvoice_TotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Invoice_Item", Storage="_Items", ThisKey="Invoice_Id", OtherKey="Invoice_Id")]
		public EntitySet<Item> Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Invoice", Storage="_User", ThisKey="Username", OtherKey="Username", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Invoices.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Invoices.Add(this);
						this._Username = value.Username;
					}
					else
					{
						this._Username = default(string);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.Invoice = this;
		}
		
		private void detach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.Invoice = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Invoice_Id;
		
		private int _Product_Id;
		
		private int _Item_Qty;
		
		private decimal _Item_SellingPrice;
		
		private EntityRef<Invoice> _Invoice;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInvoice_IdChanging(int value);
    partial void OnInvoice_IdChanged();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    partial void OnItem_QtyChanging(int value);
    partial void OnItem_QtyChanged();
    partial void OnItem_SellingPriceChanging(decimal value);
    partial void OnItem_SellingPriceChanged();
    #endregion
		
		public Item()
		{
			this._Invoice = default(EntityRef<Invoice>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Invoice_Id
		{
			get
			{
				return this._Invoice_Id;
			}
			set
			{
				if ((this._Invoice_Id != value))
				{
					if (this._Invoice.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInvoice_IdChanging(value);
					this.SendPropertyChanging();
					this._Invoice_Id = value;
					this.SendPropertyChanged("Invoice_Id");
					this.OnInvoice_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Qty", DbType="Int NOT NULL")]
		public int Item_Qty
		{
			get
			{
				return this._Item_Qty;
			}
			set
			{
				if ((this._Item_Qty != value))
				{
					this.OnItem_QtyChanging(value);
					this.SendPropertyChanging();
					this._Item_Qty = value;
					this.SendPropertyChanged("Item_Qty");
					this.OnItem_QtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_SellingPrice", DbType="Money NOT NULL")]
		public decimal Item_SellingPrice
		{
			get
			{
				return this._Item_SellingPrice;
			}
			set
			{
				if ((this._Item_SellingPrice != value))
				{
					this.OnItem_SellingPriceChanging(value);
					this.SendPropertyChanging();
					this._Item_SellingPrice = value;
					this.SendPropertyChanged("Item_SellingPrice");
					this.OnItem_SellingPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Invoice_Item", Storage="_Invoice", ThisKey="Invoice_Id", OtherKey="Invoice_Id", IsForeignKey=true)]
		public Invoice Invoice
		{
			get
			{
				return this._Invoice.Entity;
			}
			set
			{
				Invoice previousValue = this._Invoice.Entity;
				if (((previousValue != value) 
							|| (this._Invoice.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Invoice.Entity = null;
						previousValue.Items.Remove(this);
					}
					this._Invoice.Entity = value;
					if ((value != null))
					{
						value.Items.Add(this);
						this._Invoice_Id = value.Invoice_Id;
					}
					else
					{
						this._Invoice_Id = default(int);
					}
					this.SendPropertyChanged("Invoice");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Item", Storage="_Product", ThisKey="Product_Id", OtherKey="Product_Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Items.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Items.Add(this);
						this._Product_Id = value.Product_Id;
					}
					else
					{
						this._Product_Id = default(int);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Product_Id;
		
		private string _Product_Name;
		
		private decimal _Product_Price;
		
		private string _Product_Description;
		
		private string _Product_Type;
		
		private string _Product_Img;
		
		private int _Product_NumSold;
		
		private int _Product_OnHand;
		
		private bool _Product_IsSpecial;
		
		private System.Nullable<float> _Product_SpclPercantage;
		
		private string _Product_Brand;
		
		private EntitySet<Item> _Items;
		
		private EntitySet<Wishlist> _Wishlists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    partial void OnProduct_NameChanging(string value);
    partial void OnProduct_NameChanged();
    partial void OnProduct_PriceChanging(decimal value);
    partial void OnProduct_PriceChanged();
    partial void OnProduct_DescriptionChanging(string value);
    partial void OnProduct_DescriptionChanged();
    partial void OnProduct_TypeChanging(string value);
    partial void OnProduct_TypeChanged();
    partial void OnProduct_ImgChanging(string value);
    partial void OnProduct_ImgChanged();
    partial void OnProduct_NumSoldChanging(int value);
    partial void OnProduct_NumSoldChanged();
    partial void OnProduct_OnHandChanging(int value);
    partial void OnProduct_OnHandChanged();
    partial void OnProduct_IsSpecialChanging(bool value);
    partial void OnProduct_IsSpecialChanged();
    partial void OnProduct_SpclPercantageChanging(System.Nullable<float> value);
    partial void OnProduct_SpclPercantageChanged();
    partial void OnProduct_BrandChanging(string value);
    partial void OnProduct_BrandChanged();
    #endregion
		
		public Product()
		{
			this._Items = new EntitySet<Item>(new Action<Item>(this.attach_Items), new Action<Item>(this.detach_Items));
			this._Wishlists = new EntitySet<Wishlist>(new Action<Wishlist>(this.attach_Wishlists), new Action<Wishlist>(this.detach_Wishlists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Product_Name
		{
			get
			{
				return this._Product_Name;
			}
			set
			{
				if ((this._Product_Name != value))
				{
					this.OnProduct_NameChanging(value);
					this.SendPropertyChanging();
					this._Product_Name = value;
					this.SendPropertyChanged("Product_Name");
					this.OnProduct_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Price", DbType="Money NOT NULL")]
		public decimal Product_Price
		{
			get
			{
				return this._Product_Price;
			}
			set
			{
				if ((this._Product_Price != value))
				{
					this.OnProduct_PriceChanging(value);
					this.SendPropertyChanging();
					this._Product_Price = value;
					this.SendPropertyChanged("Product_Price");
					this.OnProduct_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Product_Description
		{
			get
			{
				return this._Product_Description;
			}
			set
			{
				if ((this._Product_Description != value))
				{
					this.OnProduct_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._Product_Description = value;
					this.SendPropertyChanged("Product_Description");
					this.OnProduct_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Product_Type
		{
			get
			{
				return this._Product_Type;
			}
			set
			{
				if ((this._Product_Type != value))
				{
					this.OnProduct_TypeChanging(value);
					this.SendPropertyChanging();
					this._Product_Type = value;
					this.SendPropertyChanged("Product_Type");
					this.OnProduct_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Img", DbType="VarChar(50)")]
		public string Product_Img
		{
			get
			{
				return this._Product_Img;
			}
			set
			{
				if ((this._Product_Img != value))
				{
					this.OnProduct_ImgChanging(value);
					this.SendPropertyChanging();
					this._Product_Img = value;
					this.SendPropertyChanged("Product_Img");
					this.OnProduct_ImgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_NumSold", DbType="Int NOT NULL")]
		public int Product_NumSold
		{
			get
			{
				return this._Product_NumSold;
			}
			set
			{
				if ((this._Product_NumSold != value))
				{
					this.OnProduct_NumSoldChanging(value);
					this.SendPropertyChanging();
					this._Product_NumSold = value;
					this.SendPropertyChanged("Product_NumSold");
					this.OnProduct_NumSoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_OnHand", DbType="Int NOT NULL")]
		public int Product_OnHand
		{
			get
			{
				return this._Product_OnHand;
			}
			set
			{
				if ((this._Product_OnHand != value))
				{
					this.OnProduct_OnHandChanging(value);
					this.SendPropertyChanging();
					this._Product_OnHand = value;
					this.SendPropertyChanged("Product_OnHand");
					this.OnProduct_OnHandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_IsSpecial", DbType="Bit NOT NULL")]
		public bool Product_IsSpecial
		{
			get
			{
				return this._Product_IsSpecial;
			}
			set
			{
				if ((this._Product_IsSpecial != value))
				{
					this.OnProduct_IsSpecialChanging(value);
					this.SendPropertyChanging();
					this._Product_IsSpecial = value;
					this.SendPropertyChanged("Product_IsSpecial");
					this.OnProduct_IsSpecialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_SpclPercantage", DbType="Real")]
		public System.Nullable<float> Product_SpclPercantage
		{
			get
			{
				return this._Product_SpclPercantage;
			}
			set
			{
				if ((this._Product_SpclPercantage != value))
				{
					this.OnProduct_SpclPercantageChanging(value);
					this.SendPropertyChanging();
					this._Product_SpclPercantage = value;
					this.SendPropertyChanged("Product_SpclPercantage");
					this.OnProduct_SpclPercantageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Brand", DbType="VarChar(50)")]
		public string Product_Brand
		{
			get
			{
				return this._Product_Brand;
			}
			set
			{
				if ((this._Product_Brand != value))
				{
					this.OnProduct_BrandChanging(value);
					this.SendPropertyChanging();
					this._Product_Brand = value;
					this.SendPropertyChanged("Product_Brand");
					this.OnProduct_BrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Item", Storage="_Items", ThisKey="Product_Id", OtherKey="Product_Id")]
		public EntitySet<Item> Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Wishlist", Storage="_Wishlists", ThisKey="Product_Id", OtherKey="Product_Id")]
		public EntitySet<Wishlist> Wishlists
		{
			get
			{
				return this._Wishlists;
			}
			set
			{
				this._Wishlists.Assign(value);
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
		
		private void attach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Wishlists(Wishlist entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Wishlists(Wishlist entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Wishlist")]
	public partial class Wishlist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private int _Product_Id;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    #endregion
		
		public Wishlist()
		{
			this._Product = default(EntityRef<Product>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Wishlist", Storage="_Product", ThisKey="Product_Id", OtherKey="Product_Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Wishlists.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Wishlists.Add(this);
						this._Product_Id = value.Product_Id;
					}
					else
					{
						this._Product_Id = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Wishlist", Storage="_User", ThisKey="Username", OtherKey="Username", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Wishlists.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Wishlists.Add(this);
						this._Username = value.Username;
					}
					else
					{
						this._Username = default(string);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _UserType;
		
		private string _FirstName;
		
		private string _Surname;
		
		private string _Email;
		
		private string _AddressLine1;
		
		private string _AddressLine2;
		
		private string _ZipCode;
		
		private System.Nullable<System.DateTime> _DateRegistered;
		
		private EntitySet<Invoice> _Invoices;
		
		private EntitySet<Wishlist> _Wishlists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressLine1Changing(string value);
    partial void OnAddressLine1Changed();
    partial void OnAddressLine2Changing(string value);
    partial void OnAddressLine2Changed();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnDateRegisteredChanging(System.Nullable<System.DateTime> value);
    partial void OnDateRegisteredChanged();
    #endregion
		
		public User()
		{
			this._Invoices = new EntitySet<Invoice>(new Action<Invoice>(this.attach_Invoices), new Action<Invoice>(this.detach_Invoices));
			this._Wishlists = new EntitySet<Wishlist>(new Action<Wishlist>(this.attach_Wishlists), new Action<Wishlist>(this.detach_Wishlists));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(56) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressLine1", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string AddressLine1
		{
			get
			{
				return this._AddressLine1;
			}
			set
			{
				if ((this._AddressLine1 != value))
				{
					this.OnAddressLine1Changing(value);
					this.SendPropertyChanging();
					this._AddressLine1 = value;
					this.SendPropertyChanged("AddressLine1");
					this.OnAddressLine1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressLine2", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string AddressLine2
		{
			get
			{
				return this._AddressLine2;
			}
			set
			{
				if ((this._AddressLine2 != value))
				{
					this.OnAddressLine2Changing(value);
					this.SendPropertyChanging();
					this._AddressLine2 = value;
					this.SendPropertyChanged("AddressLine2");
					this.OnAddressLine2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateRegistered", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateRegistered
		{
			get
			{
				return this._DateRegistered;
			}
			set
			{
				if ((this._DateRegistered != value))
				{
					this.OnDateRegisteredChanging(value);
					this.SendPropertyChanging();
					this._DateRegistered = value;
					this.SendPropertyChanged("DateRegistered");
					this.OnDateRegisteredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Invoice", Storage="_Invoices", ThisKey="Username", OtherKey="Username")]
		public EntitySet<Invoice> Invoices
		{
			get
			{
				return this._Invoices;
			}
			set
			{
				this._Invoices.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Wishlist", Storage="_Wishlists", ThisKey="Username", OtherKey="Username")]
		public EntitySet<Wishlist> Wishlists
		{
			get
			{
				return this._Wishlists;
			}
			set
			{
				this._Wishlists.Assign(value);
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
		
		private void attach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Invoices(Invoice entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Wishlists(Wishlist entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Wishlists(Wishlist entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
