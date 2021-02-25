--create database MyDatabase
create table Brands
(
BrandId int 
PRIMARY KEY(BrandId),
BrandName char(50)

)

create table Colors
(
ColorId int,
PRIMARY KEY(ColorId),
ColorName char(30)

)

create table Cars
(
Id int,
PRIMARY KEY(Id),
DailyPrice float,
Description varchar(50),
ModelYear char(5),
BrandId int,
ColorId int,
FOREIGN KEY (BrandId) references Brands,
FOREIGN KEY (ColorId) references Colors

)



