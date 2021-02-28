using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        //List<Car> GetCarsByColorId(int id);

        //List<Car> GetCarsByBrandId(int id);

        Car GetById(int id);

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);

        List<CarDetailDto> GetCarDetails();
    }
}
