using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<Car>> GetCarsByBrandId(int brandId);

        IDataResult<Car> GetById(int carId);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
