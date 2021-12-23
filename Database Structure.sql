CREATE DATABASE DMX
GO 
USE DMX
GO

CREATE TABLE CUSTOMER
(
	CustomerID varchar(30) not null,
	[Name] nvarchar(30) not null,
	[Address] nvarchar(max) not null,
	Phone nvarchar(10) not null,
	Gender bit not null,

	Primary key (CustomerID)
)
GO

CREATE TABLE STAFF
(
	StaffID varchar(30) not null,
	[Name] nvarchar(30) not null,
	[Address] nvarchar(max) not null,
	Phone varchar(10) not null,
	Gender bit not null,
	Position nvarchar(30) not null,

	Primary key (StaffID),
	--Foreign key (StaffID) references STAFF (StaffID), 
	
)

CREATE TABLE ACCOUNT
(
	StaffID varchar(30) not null,
	LoginName varchar(30) not null unique,
	[Password] varchar(30) not null,
	[Permission] varchar(30) not null,

	Primary key (StaffID),
	Foreign key (StaffID) references STAFF (StaffID), 
)
GO

CREATE TABLE RECIEPT
(
	RecieptID varchar(30) not null,
	CustomerID varchar(30) not null,
	StaffID varchar(30) not null,
	PaymentMethod nvarchar(30) not null,
	CreateAt datetime default getdate() not null,
	Total decimal not null,

	Primary key (RecieptID),
	Foreign key (StaffID) references STAFF (StaffID),
	Foreign key (CustomerID) references CUSTOMER (CustomerID)
)
GO

CREATE TABLE BRAND
(
	BrandID varchar(30) not null,
	[Name] nvarchar(30) not null,
	[Address] nvarchar(max) not null,

	Primary key (BrandID)
)
GO

CREATE TABLE CATEGORY
(
	CategoryID varchar(30) not null,
	[Name] nvarchar(30) not null,
	CreateAt datetime default getdate() not null,
	[Des] nvarchar(max),

	primary key (CategoryID)
)
GO

CREATE TABLE PRODUCT
(
	ProductID varchar(30) not null,
	BrandID varchar(30) not null,
	CategoryID varchar(30) not null,
	[Name] nvarchar(30) not null,
	Price decimal not null,

	Primary key (ProductID),
	Foreign key (BrandID) references BRAND (BrandID),
	Foreign key (CategoryID) references CATEGORY (CategoryID)
)
GO

CREATE TABLE CARTITEM
(
	RecieptID varchar(30) not null,
	ProductID varchar(30) not null,
	Quantity numeric not null,
	SubTotal decimal not null,

	Primary key (RecieptID, ProductID),
	Foreign key (RecieptID) references RECIEPT (RecieptID),
	Foreign key (ProductID) references PRODUCT (ProductID)
)
GO

CREATE TABLE WAREHOUSE
(
	WarehouseID varchar(30) not null,
	[Name] nvarchar(30) not null,
	[Address] nvarchar(max) not null,

	Primary key (WarehouseID)
)
GO

CREATE TABLE PRODUCTAVAILABLE
(
	WarehouseID varchar(30) not null,
	ProductID varchar(30) not null,
	Quantity numeric not null,

	Primary key (WarehouseID, ProductID),
	Foreign key (WarehouseID) references WAREHOUSE (WarehouseID),
	Foreign key (ProductID) references PRODUCT (ProductID)
)
GO

CREATE TABLE IESLIP
(
	IESlipID varchar(30) not null,
	CreateAt datetime default getdate() not null,
	TotalPrice decimal not null,
	StaffID varchar(30) not null,
	WarehouseID varchar(30) not null,

	Primary key (IESlipID),
	Foreign key (WarehouseID) references WAREHOUSE (WarehouseID),
	Foreign key (StaffID) references STAFF (StaffID)
)
GO

CREATE TABLE IESLIPDETAIL
(
	IESlipID varchar(30) not null,
	ProductID varchar(30) not null,
	Quantity numeric not null,

	Primary key (IESlipID, ProductID),
	Foreign key (IESlipID) references IESLIP (IESlipID),
	Foreign key (ProductID) references PRODUCT (ProductID)
)
GO


INSERT INTO STAFF VALUES ('NV0932765080', N'Võ Đoàn Hoàng Long', N'Éo có', '0932765080', 1, N'Quản Lý')
INSERT INTO ACCOUNT VALUES('NV0932765080', 'hoanglong', '1', 'Manager')

