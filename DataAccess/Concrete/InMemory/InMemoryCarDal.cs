using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //bellekte referans alınınca onstructor yapılmalı
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId=1, BrandId =1, ColorId =1, DailyPrice =70, CarName="Black Audi", ModelYear = 2006},
                new Car{ CarId=2, BrandId=1, ColorId =2, DailyPrice = 100, CarName ="Grey Audi", ModelYear = 2010},
                new Car{ CarId=3, BrandId=2, ColorId =1, DailyPrice =140, CarName="Black BMW", ModelYear = 2016},
                new Car{ CarId=4, BrandId=3, ColorId=3, DailyPrice=120, CarName="White Volvo", ModelYear = 2012}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> Get(int id)
        {
            return _cars.Where(p => p.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.CarName = car.CarName;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
