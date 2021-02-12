using Bussiness.Abstract;
using Bussiness.Constands;
using DataAccess.Abstract;
using DataAccess.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult AddBrand(Brand brand)
        {
            if (brand!=null)
            {
                _brandDal.Add(brand);
            }
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult DeleteBrand(Brand brand)
        {
            if (brand != null)
            {
                _brandDal.Delete(brand);
            }
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll().ToList(),Messages.BrandListed);
        }

        public IDataResult<List<Brand>> GetBrandsByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll().Where(x => x.Id == id).ToList(),Messages.BrandListed);
        }

        public IResult UpdateBrand(Brand brand)
        {
            if (brand != null)
            {
                _brandDal.Update(brand);
            }
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
