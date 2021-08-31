CREATE TABLE TBL_USERS (
Id int  identity (1,1)  not null primary key,
FirstName varchar (50) not null,
LastName varchar (50) not null,
Email varchar (50) null,
CityId int not null,
PhoneNumber varchar (20) not null,
wasDeleted bit not null default 0,
UserName varchar (30) not null,
HashedPassword varbinary(200),
 FOREIGN KEY(CityId) REFERENCES TBL_City (Id)

)

CREATE TABLE TBL_City (
Id Int not null Primary key,
CityName varchar(50) not null,
PostalCode varchar(20) not null,
RegionId int not null,
 FOREIGN KEY(RegionId) REFERENCES TBL_Region (Id)
 )

CREATE TABLE TBL_Region (
Id int not null Primary key,
RegionName varchar (30) not null
)


