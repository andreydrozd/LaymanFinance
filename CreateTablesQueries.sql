CREATE TABLE Outlay
(
	ID int identity not null,
	DateOccurred date not null,
	DateEntered datetime not null DEFAULT (GetDate()),
	DateModified datetime null DEFAULT (GetDate()),
	[Amount] money not null,
	Payee nvarchar(50) not null,
	Memo nvarchar(160) null, 
	CONSTRAINT PK_Outlay PRIMARY KEY(ID),
	CONSTRAINT FK_Outlay_Category FOREIGN KEY (CategoryID) REFERENCES Category(ID)
)

CREATE TABLE Category
(
	ID int identity not null,
	[Name] nvarchar(50) not null,
	BudgetedAmount money not null,
	ActivityAmount money null,
	AvailableAmount money null,
	CONSTRAINT PK_Category PRIMARY KEY(ID)
)

CREATE TABLE Inflow
(
	ID int identity not null,
	DateOccurred date not null,
	DateEntered datetime not null DEFAULT (GetDate()),
	DateModified datetime null DEFAULT (GetDate()),
	[Amount] money not null,
	Payor nvarchar(50) not null,
	Memo nvarchar(160) null, 
	CONSTRAINT PK_Inflow PRIMARY KEY(ID),
	CONSTRAINT FK_Inflow_Category FOREIGN KEY (CategoryID) REFERENCES Category(ID)
)

CREATE TABLE [Service]
(
	ID int identity not null,
	[Name] nvarchar(50) not null,
	Price money not null,


)

CREATE TABLE ServiceDetail
(

)

CREATE TABLE [Order]
(

)

CREATE TABLE OrderContent
(

)

CREATE TABLE Promo
(
	ID int identity not null,
	Code nvarchar(100) not null,
	PercentageOff decimal not null,
	CONSTRAINT PK_Promo PRIMARY KEY(ID),
	CONSTRAINT FK_Promo_Service FOREIGN KEY(ServiceID) REFERENCES Service(ID)
)

CREATE TABLE Testimonial
(

)


