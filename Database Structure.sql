CREATE DATABASE DMX
GO 
USE DMX
GO

CREATE TABLE CUSTOMER
(
	CustomerID varchar not null,
	[Name] nvarchar not null,
	[Address] nvarchar not null,
	Phone nvarchar not null,
	Gender bit not null,

	Primary key (CustomerID)
)
GO

CREATE TABLE STAFF
(
	StaffID varchar not null,
	[Name] nvarchar not null,
	[Address] nvarchar not null,
	Phone varchar not null,
	Gender bit not null,
	Position nvarchar not null,

	Primary key (StaffID),
	Foreign key (StaffID) references STAFF (StaffID), 
	
)

CREATE TABLE ACCOUNT
(
	StaffID varchar not null,
	LoginName varchar not null,
	[Password] varchar not null,
	[Permission] varchar not null,

	Primary key (StaffID),
	Foreign key (StaffID) references STAFF (StaffID), 
)
GO

CREATE TABLE RECIEPT
(
	RecieptID varchar not null,
	CustomerID varchar not null,
	StaffID varchar not null,
	PaymentMethod nvarchar not null,
	CreateAt datetime default getdate() not null,
	Total decimal not null,

	Primary key (RecieptID),
	Foreign key (StaffID) references STAFF (StaffID),
	Foreign key (CustomerID) references CUSTOMER (CustomerID)
)
GO

CREATE TABLE BRAND
(
	BrandID varchar not null,
	[Name] nvarchar not null,
	[Address] nvarchar not null,

	Primary key (BrandID)
)
GO

CREATE TABLE CATEGORY
(
	CategoryID varchar not null,
	[Name] nvarchar not null,
	[Des] nvarchar,

	primary key (CategoryID)
)

CREATE TABLE PRODUCT
(
	ProductID varchar not null,
	BrandID varchar not null,
	CategoryID varchar not null,
	[Name] nvarchar not null,
	Price decimal not null,

	Primary key (ProductID),
	Foreign key (BrandID) references BRAND (BrandID),
	Foreign key (CategoryID) references CATEGORY (CategoryID)
)
GO

CREATE TABLE CARTITEM
(
	RecieptID varchar not null,
	ProductID varchar not null,
	Quantity numeric not null,
	SubTotal decimal not null,

	Primary key (RecieptID, ProductID),
	Foreign key (RecieptID) references RECIEPT (RecieptID),
	Foreign key (ProductID) references PRODUCT (ProductID)
)
GO

CREATE TABLE WAREHOUSE
(
	WarehouseID varchar not null,
	[Name] nvarchar not null,
	[Address] nvarchar not null,

	Primary key (WarehouseID)
)
GO

CREATE TABLE PRODUCTAVAILABLE
(
	WarehouseID varchar not null,
	ProductID varchar not null,
	Quantity numeric not null,

	Primary key (WarehouseID, ProductID),
	Foreign key (WarehouseID) references WAREHOUSE (WarehouseID),
	Foreign key (ProductID) references PRODUCT (ProductID)
)
GO

CREATE TABLE IESLIP
(
	IESlipID varchar not null,
	CreateAt datetime default getdate() not null,
	TotalPrice decimal not null,
	StaffID varchar not null,
	WarehouseID varchar not null,

	Primary key (IESlipID),
	Foreign key (WarehouseID) references WAREHOUSE (WarehouseID),
	Foreign key (StaffID) references STAFF (StaffID)
)
GO

CREATE TABLE IESLIPDETAIL
(
	IESlipID varchar not null,
	ProductID varchar not null,
	Quantity numeric not null,

	Primary key (IESlipID, ProductID),
	Foreign key (IESlipID) references IESLIP (IESlipID),
	Foreign key (ProductID) references PRODUCT (ProductID)
)
GO