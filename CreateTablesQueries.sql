CREATE TABLE Outlay
(
	ID int identity not null,
	CategoryID int not null,
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
	CategoryID int not null,
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
	DescriptionOne nvarchar(160) not null,
	DescriptionTwo nvarchar(160) null,
	DescriptionThree nvarchar(160) null,
	CONSTRAINT PK_Service PRIMARY KEY(ID)
)

CREATE TABLE ServiceDetail
(
	ID int identity not null,
	ServiceID int not null,
	PromoID int not null,
	BeginDate datetime not null,
	EndDate datetime not null,
	CONSTRAINT PK_ServiceDetail PRIMARY KEY(ID),
	CONSTRAINT FK_ServiceDetail_Service FOREIGN KEY (ServiceID) REFERENCES Service(ID),
	CONSTRAINT FK_ServiceDetail_Promo FOREIGN KEY (PromoID) REFERENCES Promo(ID)
)

CREATE TABLE [Order]
(
	ID int identity not null,
	Total money not null,
    DateCreated datetime not null DEFAULT (GetDate()),
	DateModified datetime null DEFAULT (GetDate()),
    CONSTRAINT PK_Order PRIMARY KEY(ID)
)

CREATE TABLE Promo
(
	ID int identity not null,
	Code nvarchar(100) not null,
	PercentageOff decimal not null,
	CONSTRAINT PK_Promo PRIMARY KEY(ID),
)

CREATE TABLE Testimonial
(
	ID int identity not null,
	ServiceID int not null,
	[Name] nvarchar(50) not null,
	[Location] nvarchar(50) not null,
	ImageURL nvarchar(100) not null,
	TextOne nvarchar(160) not null,
	TextTwo nvarchar(160) null,
	TextThree nvarchar(160) null,
	CONSTRAINT PK_Testimonial PRIMARY KEY(ID),
	CONSTRAINT FK_Testimonial_Service FOREIGN KEY (ServiceID) REFERENCES Service(ID)
)


