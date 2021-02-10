using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class ImCarDal : ICarDal
    {
        List<Car> _cars;
        public ImCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,ColorId=1,BrandId=1,DailyPrice=150,Description="Fiat Ega 5 Kapı",ModelYear=2019 },
                new Car{Id=2,ColorId=1,BrandId=1,DailyPrice=200,Description="Fiat Ega Sedan",ModelYear=2020 },
                new Car{Id=3,ColorId=2,BrandId=2,DailyPrice=250,Description="Ford Focus",ModelYear=2019 },
                new Car{Id=4,ColorId=2,BrandId=2,DailyPrice=400,Description="Ford Mondeo",ModelYear=2020 },
                new Car{Id=5,ColorId=2,BrandId=3,DailyPrice=600,Description="BMW 320d",ModelYear=2020 },
            };
        }
        public void Add(Car cars)
        {
            _cars.Add(cars);
        }

        public void Delete(Car cars)
        {
            Car carDelete = _cars.FirstOrDefault(x => x.Id == cars.Id);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            var getAllCars = _cars.ToList();
            return getAllCars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return null;
        }

        public Car GetById(int id)
        {
            var getCar = _cars.Where(x => x.Id == id).FirstOrDefault();
            return getCar;
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return null;
        }

        public void Update(Car cars)
        {
            Car carUpdate = _cars.FirstOrDefault(x => x.Id == cars.Id);
            carUpdate.ColorId = cars.ColorId;
            carUpdate.BrandId = cars.BrandId;
            carUpdate.DailyPrice = cars.DailyPrice;
            carUpdate.Description = cars.Description;
            carUpdate.ModelYear = cars.ModelYear;
        }
    }
}
