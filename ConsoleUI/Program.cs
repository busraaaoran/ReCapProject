using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();

            //ColorTest();

            //CustomerTest();

            //UserTest();

            RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { CarId = 4, CustomerId = 1, RentDate = DateTime.Now });
            //rentalManager.Delete(new Rental { RentDate = DateTime.Now, RentalId = 5, CustomerId = 1, CarId = 4 , ReturnDate = new DateTime(1,01,0001)});
            var result = rentalManager.GetAll();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine("Car with ID: "+rental.CarId + " rented at " + rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorId = 5, ColorName = "Blue" });

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Update(new Brand { BrandId = 4, BrandName = "Skoda" });
            //brandManager.Update(new Brand { BrandId = 4, BrandName = "Renault" });

            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 440, CarName = "118i First Edition Sport Line", ModelYear = 2020 });

            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 230, CarName = "A3 Sportback 1.6 Attraction", ModelYear = 2010 });

            //carManager.Delete(new Car { BrandId = 1, ColorId = 2, DailyPrice = 230, ModelYear = 2010, CarName = "A3 Sportback 1.6 Attraction", Id = 22 });

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.CarName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
