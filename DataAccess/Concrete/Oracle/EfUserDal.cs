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
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//ekle
            }
        }

        public void Delete(User entity)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return filter == null ? context.Set<User>().ToList() : context.Set<User>().Where(filter).ToList(); 
            }
        }

        public void Update(User entity)
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
