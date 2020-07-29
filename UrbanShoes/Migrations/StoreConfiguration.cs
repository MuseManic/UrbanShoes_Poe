

namespace UrbanShoes.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;
    using System;
    internal sealed class StoreConfiguration : DbMigrationsConfiguration<UrbanShoes.DAL.MainStore>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UrbanShoes.DAL.MainStore context)
        {

            var categories = new List<Category>
            {
                new Category { Name = "Takkies" },
                new Category { Name = "Sneakers" },
                new Category { Name = "Loafers" },
                new Category { Name = "Boots" },
                new Category { Name= "Wedges" },
                new Category { Name= "Stlettos" },
                new Category { Name= "Ugg Boots" },
                new Category { Name= "Combat Boots" },
                new Category { Name= "Flip Flops" },
                new Category { Name= "High Heels" },
                new Category { Name= "Golf Shoes" },
                new Category { Name= "Jump Shoes" },
                new Category { Name= "Oxfords" },
                new Category { Name= "Pumps" },
                new Category { Name= "Sandals" },
                new Category { Name= "Track Shoes" }



            };

            var products = new List<Product>
            {
                  new Product { Name = "Stock Shoe 1", Description="To illustrate populating of product",Price=5.0M, CategoryID=categories.Single( c => c.Name == "Flip Flops").ID },
                new Product { Name = "Stock Shoe 2", Description="To illustrate populating of product", Price=5.0M, CategoryID=categories.Single( c => c.Name == "Flip Flops").ID },
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",
                 County="County", Postcode="PostCode" }, TotalPrice=4.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 1) ,
                 DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",
                 County="County", Postcode="PostCode" }, TotalPrice=2.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 2) ,
                 DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",
                 County="County", Postcode="PostCode" }, TotalPrice=1.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 3) ,
                 DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",
                 County="County", Postcode="PostCode" }, TotalPrice=24.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 4) ,
                 DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",
                 County="County", Postcode="PostCode" }, TotalPrice=8.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 5) ,
                 DeliveryName="Admin" }
            };

            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();

            var orderLines = new List<OrderLine>
            {
                new OrderLine { OrderID = 1, ProductID = products.Single( c=> c.Name == "Stock Shoe 1").ID,
                    ProductName ="Stock Shoe 1", Quantity =1, UnitPrice=products.Single( c=> c.Name == "Stock Shoe 1").Price },
                new OrderLine { OrderID = 2, ProductID = products.Single( c=> c.Name == "Stock Shoe 2").ID,
                 ProductName="Stock Shoe 2", Quantity=1, UnitPrice=products.Single( c=> c.Name =="Stock Shoe 2").Price }
               
            };

            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => ol.OrderID, c));
            context.SaveChanges();


        }
    }
}