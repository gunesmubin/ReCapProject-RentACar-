using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            if (car.Description.Length>2&& car.DailyPrice > 0)
            {
                _carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Eklenemedi. Araç adını veya günlük fiyatını kontrol ediniz.");
            }
        }

        public void DeleteCar(Car car)
        {
            if (car!=null)
            {
                _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {

            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetail();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll().Where(x => x.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll().Where(x => x.ColorId == id).ToList();
        }

        public void UpdateCar(Car car)
        {
            if (car != null)
            {
                _carDal.Update(car);
            }
        }
    }
}
