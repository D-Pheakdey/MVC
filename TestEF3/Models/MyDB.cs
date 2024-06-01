using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestEF3.Migrations;

namespace TestEF3.Models
{
    public class MyDB : DbContext
    {
        public DbSet<Category> category { get; set; }
        public DbSet<Unit> unit { get; set; }
        public DbSet<Clients> clients { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Address> address { get; set; }
        public DbSet<Staff> staff { get; set; }
        public DbSet<Gender> gender { get; set; }
        public DbSet<Product> product { get; set; }


    }
}