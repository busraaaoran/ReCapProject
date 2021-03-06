create table Rentals(
RentalId int,
CarId int,
CustomerId int,
RentDate date,
ReturnDate date,
primary key(RentalId),
foreign key(CarId) references Cars(CarId),
foreign key(CustomerId) references Customers(CustomerId)

);