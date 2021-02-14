using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context nesnesi : DB tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        //override onconfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  // bu metod projem hangi veritabanı ile ilişkilidir onu sağlar.
        {
            //connection string
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-39MM41R; Database =Northwind; Trusted_Connection=true");
        }

        //hangi nesnem veritabanında hangi tabloya karşılık gelecek.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
