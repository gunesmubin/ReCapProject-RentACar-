using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetBrandsByBrandId(int id);
        IResult AddBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IResult DeleteBrand(Brand brand);

    }
}
