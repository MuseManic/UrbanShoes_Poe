using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrbanShoes.Models;
using System.Data.Entity;

namespace UrbanShoes.DAL
{
    public class MainStore : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
              
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductImageMappings> ProductImageMappings { get; set; }
        public DbSet<BasketLines> BasketLines { get; set; } 
    }
}


