using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***** Brand İşlemleri *****");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.AddBrand(new Brand {Name="BMW" });
            var brands=brandManager.GetAll();
            foreach (var item in brands)
            {
                System.Console.WriteLine("Araç Markası : {0} ", item.Name);
            }


            System.Console.WriteLine("***** Color İşlemleri *****");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.AddColor(new Color {Name="Kırmızı" });
            var colors=colorManager.GetAll();
            foreach (var item in colors)
            {
                System.Console.WriteLine("Araç Markası : {0} ", item.Name);
            }


            System.Console.WriteLine("***** Car İşlemleri *****");
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.AddCar( new Car {ColorId=1,BrandId=2,ModelYear=2021,DailyPrice=300,Description="Egea 5 Kapı"});
            var carDetail=carManager.GetCarDetail();
            foreach (var item in carDetail)
            {
                System.Console.WriteLine("Araç Markası : {0}  Araç Modeli :{1}  Araç Rengi :{2}  Günlük Fiyatı :{3} ",item.CarName,item.BrandName,item.ColorName,item.DailyPrice);
            }   
            
;        }
    }
}
