using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand brand)
        {
            using (RentACarContext context =new RentACarContext())
            {
                var brandAdd = context.Entry(brand);
                brandAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand brand)
        {
            using (RentACarContext context=new RentACarContext())
            {
                var brandDelete = context.Entry(brand);
                brandDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarContext context =new RentACarContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand brand)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var brandUpdate = context.Entry(brand);
                brandUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
