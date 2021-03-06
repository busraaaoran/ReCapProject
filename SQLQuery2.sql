create table Users(
UserId int identity(1,1),
primary key(UserId),
FirstName nvarchar(20),
LastName nvarchar(20),
Email nvarchar(50),
Password nvarchar(20)
);

create table Customers(
CompanyName nvarchar(50),
UserId int,
primary key(UserId),
foreign key(UserId) references Users(UserId)

);