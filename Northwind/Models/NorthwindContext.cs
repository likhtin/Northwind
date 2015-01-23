using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Northwind.Models
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}