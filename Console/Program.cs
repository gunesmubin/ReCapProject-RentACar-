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

            //RentalManager rentalManagerRent = new RentalManager(new EfRentalDal());
            //var rentalRentRes = rentalManagerRent.RentCar(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null });
            //System.Console.WriteLine(rentalRentRes.Message);

            //RentalManager rentalManagerBack = new RentalManager(new EfRentalDal());
            //var rentalBackRes = rentalManagerBack.RentBackCar(new Rental { CarId = 1, CustomerId = 1, ReturnDate = DateTime.Now });
            //System.Console.WriteLine(rentalBackRes.Message);

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var addCustomerRes= customerManager.AddCustomer(new Customer { UserId = 1, CompanyName = "Company 1" });
            System.Console.WriteLine(addCustomerRes.Message);




            UserManager userManager = new UserManager(new EfUserDal());
            var addUserRes = userManager.AddUser(new User {FirstName="Hasan",LastName="Mutlu",Email="hmutlu@aaa.com",Password="123456" });
            System.Console.WriteLine(addUserRes.Message);



            //System.Console.WriteLine("***** Brand İşlemleri *****");
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //var brandAddRes =brandManager.AddBrand(new Brand {Name="BMW" });
            //if (brandAddRes.Success==true)
            //{
            //    System.Console.WriteLine(brandAddRes.Message);
            //}
            //else
            //{
            //    System.Console.WriteLine(brandAddRes.Message);
            //}
            //var brands=brandManager.GetAll();
            //foreach (var item in brands.Data)
            //{
            //    System.Console.WriteLine("Araç Markası : {0} ", item.Name);
            //}



            //System.Console.WriteLine("***** Color İşlemleri *****");
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //var colorAddRes=colorManager.AddColor(new Color {Name="Kırmızı" });
            //if (colorAddRes.Success==true)
            //{
            //    System.Console.WriteLine(colorAddRes.Message);
            //}
            //else
            //{
            //    System.Console.WriteLine(colorAddRes.Message);
            //}
            //var colors=colorManager.GetAll();
            //if (colors.Success==true)
            //{
            //    foreach (var item in colors.Data)
            //    {
            //        System.Console.WriteLine("Araç Markası : {0} ", item.Name);
            //    }
            //}



            //System.Console.WriteLine("***** Car İşlemleri *****");
            //CarManager carManager = new CarManager(new EfCarDal());
            //var carAddRes=carManager.AddCar( new Car {ColorId=1,BrandId=2,ModelYear=2021,DailyPrice=300,Description="Egea 5 Kapı"});
            //if (carAddRes.Success==true)
            //{
            //    System.Console.WriteLine(carAddRes.Message);
            //}
            //var carDetail=carManager.GetCarDetail();
            //if (carDetail.Success==true)
            //{
            //    foreach (var item in carDetail.Data)
            //    {
            //        System.Console.WriteLine("Araç Markası : {0}  Araç Modeli :{1}  Araç Rengi :{2}  Günlük Fiyatı :{3} ", item.CarName, item.BrandName, item.ColorName, item.DailyPrice);
            //    }
            //}


            ;        }
    }
}
