using DataAccess.Abstrack;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Oracle
{
    public class EfSoldItemsDal : ISoldItemsDal
    {
        public void Add(SoldItems entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//ekle
            }
        }

        public void Delete(SoldItems entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public SoldItems Get(Expression<Func<SoldItems, bool>> filter)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return context.Set<SoldItems>().SingleOrDefault(filter);
            }
        }

        public List<SoldItems> GetAll(Expression<Func<SoldItems, bool>> filter = null)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return filter == null ? context.Set<SoldItems>().ToList() : context.Set<SoldItems>().Where(filter).ToList();
            }
        }

        public void Update(SoldItems entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
