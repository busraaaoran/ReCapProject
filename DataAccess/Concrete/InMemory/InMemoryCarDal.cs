using DataAccess.Abstract;
using Entities.Concrete;
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
                new Car{ Id=1, BrandId =1, ColorId =1, DailyPrice =70, Description="Black Audi", ModelYear = 2006},
                new Car{ Id=2, BrandId=1, ColorId =2, DailyPrice = 100, Description ="Grey Audi", ModelYear = 2010},
                new Car{ Id=3, BrandId=2, ColorId =1, DailyPrice =140, Description="Black BMW", ModelYear = 2016},
                new Car{ Id=4, BrandId=3, ColorId=3, DailyPrice=120, Description="White Volvo", ModelYear = 2012}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

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

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
