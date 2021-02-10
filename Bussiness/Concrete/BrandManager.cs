using Bussiness.Abstract;
using DataAccess.Abstract;
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
        public void AddBrand(Brand brand)
        {
            if (brand!=null)
            {
                _brandDal.Add(brand);
            }
        }

        public void DeleteBrand(Brand brand)
        {
            if (brand != null)
            {
                _brandDal.Delete(brand);
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll().ToList();
        }

        public List<Brand> GetBrandsByBrandId(int id)
        {
            return _brandDal.GetAll().Where(x => x.Id == id).ToList();
        }

        public void UpdateBrand(Brand brand)
        {
            if (brand != null)
            {
                _brandDal.Update(brand);
            }
        }
    }
}
