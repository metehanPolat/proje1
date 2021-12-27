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
    public class EfSellingItemsDal : ISellingItemsDal
    {
        public void Add(SellingItems entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//ekle
            }
        }

        public void Delete(SellingItems entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public SellingItems Get(Expression<Func<SellingItems, bool>> filter)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return context.Set<SellingItems>().SingleOrDefault(filter);
            }
        }

        public List<SellingItems> GetAll(Expression<Func<SellingItems, bool>> filter = null)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return filter == null ? context.Set<SellingItems>().ToList() : context.Set<SellingItems>().Where(filter).ToList();
            }
        }

        public void Update(SellingItems entity)
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
