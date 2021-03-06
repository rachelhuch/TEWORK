USE master
GO
--Delete the db if it already exists
DROP DATABASE IF EXISTS ArtGallery

--create a new database
CREATE Database ArtGallery;
--Change to the new DB
USE ArtGallery;

Go

--Create the address table
create table Address (
AddressId int Primary Key Identity not null,
Address nvarchar(100) not null,
City nvarchar(50) not null, 
District nvarchar(50) null,
PostalCode nvarchar(10) null,
Country char(3) not null, 
)

Create table Customer(
CustomerId int  identity primary key, 
Name nvarchar(50), 
Phone nvarchar(15),
AddressId int not null --will need to label as a foreign key
Constraint fk_customer_address foreign key (AddressId) references Address(AddressId)
)

Create table Artist(
ArtistId int primary key identity, 
Name nvarchar(50), 
AddressId int null,
Constraint fk_artist_address foreign key (AddressId) references Address(AddressId)
)

Create table Painting(
PaintingId int primary key identity,
Title nvarchar(100) not null,
ArtistId int not null, 
IsAvailable bit not null Default 0
Constraint fk_painting_artist foreign key (ArtistId) references Artist(ArtistId)
)

Create table Trans(
TransactionId int primary key identity, 
PaintingId int not null, 
CustomerId int not null, 
TransactionDate datetime not null Default getdate(), --getdate is a built in function like datetime in c#, there is also getUTCdate
Price money not null,
IsCustomerPurchase bit not null default 1
constraint fk_trans_painting foreign key(PaintingId) references Painting(PaintingId),
constraint fk_trans_customer foreign key (CustomerId) references Customer (CustomerId)

)

