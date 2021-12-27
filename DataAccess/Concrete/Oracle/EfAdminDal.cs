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
    public class EfAdminDal : IAdminDal
    {
        public void Add(Admin entity)
        {
            
        }

        public void Delete(Admin entity)
        {
            
        }

        public Admin Get(Expression<Func<Admin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null)
        {
            using (SecondHandSaleContext context = new SecondHandSaleContext())
            {
                return filter == null ? context.Set<Admin>().ToList() : context.Set<Admin>().Where(filter).ToList(); 
            }
        }

        public void Update(Admin entity)
        {
            
        }
    }
}
