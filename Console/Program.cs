using Bussiness.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new ImCarDal());
            var getAll=carManager.GetAll();
            foreach (var item in getAll)
            {
                System.Console.WriteLine(item.Description);
            }
;        }
    }
}
