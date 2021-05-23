using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rema.Models;

namespace Rema1000.Data
{
    public class Rema1000Context : DbContext
    {
        public Rema1000Context (DbContextOptions<Rema1000Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(new {SupplierID = 1, ContactPerson = "Hans Hansen", Address = "Børgevej 123", Email = "Towel@street.com", Name = "Den store koncern", PhoneNumber = "12345678", Zip = "2200" });
            modelBuilder.Entity<Category>().HasData(new  {CategoryID = 1, Names = "Chips", Description = "Sprødesz" });
            modelBuilder.Entity<Product>().HasData(new  {ProductID = 1, Name = "Kims Sourcream & Onion", Description ="Når du er sulten for sjov",
            Unit = "Gram", Quantity = 300, Price = 20.95, Stock = 500, CategoryID = 1, SupplierID = 1, });
        }

        public DbSet<rema.Models.Category> Category { get; set; }

        public DbSet<rema.Models.Product> Product { get; set; }

        public DbSet<rema.Models.Supplier> Supplier { get; set; }
    }
}
