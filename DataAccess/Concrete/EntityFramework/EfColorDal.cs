using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color color)
        {
            using (RentACarContext context =new RentACarContext())
            {
                var colorAdd = context.Entry(color);
                colorAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color color)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var colorDelete = context.Entry(color);
                colorDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Color>().FirstOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter ==null?context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color color)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var colorUpdate = context.Entry(color);
                colorUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
