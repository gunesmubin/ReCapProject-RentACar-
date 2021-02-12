using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IRentalService
    {
        IResult RentCar(Rental rental);
        IResult RentBackCar(Rental rental);
        IDataResult<List<Rental>> GetAll();
    }
}
