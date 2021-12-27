using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Oracle
{
    public class SecondHandSaleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User Id = METEHAN;Password = Mete12345*;Data Source = localhost:1521/XEPDB1;");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SellingItems> SellingItemss { get; set; }
        public DbSet<SoldItems> SoldItemss { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
