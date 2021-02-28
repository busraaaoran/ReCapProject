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
            CarTest();

            //BrandTest();

            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorId = 5, ColorName = "Blue" });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }


        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Update(new Brand { BrandId = 4, BrandName = "Skoda" });
            //brandManager.Update(new Brand { BrandId = 4, BrandName = "Renault" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 440, CarName = "118i First Edition Sport Line", ModelYear = 2020 });

            //carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 230, CarName = "A3 Sportback 1.6 Attraction", ModelYear = 2010 });

            //carManager.Delete(new Car { BrandId = 1, ColorId = 2, DailyPrice = 230, ModelYear = 2010, CarName = "A3 Sportback 1.6 Attraction", Id = 18 });

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+"/"+car.CarName+"/"+car.ColorName+"/"+car.DailyPrice);
            }

            
        }
    }
}
