create table CarImages(

ImageId int identity(1,1),
CarId int,
ImagePath nvarchar(max),
Date datetime2(7),
primary key (ImageId),
foreign key (CarId) references Cars(CarId)
);