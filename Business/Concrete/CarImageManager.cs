using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i => i.ImageId == id));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageIsNull(carId));
        }

        private List<CarImage> CheckIfCarImageIsNull(int carId)
        {
            string path = @"\Images\default.png";
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();

            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = path } };
            }
            return _carImageDal.GetAll(c => c.CarId == carId);
        }
    }
}
