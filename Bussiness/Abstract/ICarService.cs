using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
    }
}
