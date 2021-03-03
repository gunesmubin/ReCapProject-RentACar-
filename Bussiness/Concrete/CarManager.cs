using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Aspects.Autofac.Validation;
using Bussiness.ValidationRules.FluentValidator;

namespace Bussiness.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult AddCar(Car car)
        {

          
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult DeleteCar(Car car)
        {
            if (car!=null)
            {
                _carDal.Delete(car);
            }
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<Car> GetById(int id)
        {
          var result=_carDal.Get(x => x.Id == id);
            return new SuccessDataResult<Car>(result, Messages.CarListed);

        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(x => x.BrandId == id).ToList(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(x => x.ColorId == id).ToList(),Messages.CarListed);
        }

        public IResult UpdateCar(Car car)
        {
            if (car != null)
            {
                _carDal.Update(car);
            }
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
