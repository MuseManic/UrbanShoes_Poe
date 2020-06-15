
using System.Data.Entity.Migrations;
using System.Linq;
using UrbanShoes.Models;
using System.Collections.Generic;

namespace UrbanShoes.Migrations
{
    internal sealed class StoreContext : DbMigrationsConfiguration<UrbanShoes.DAL.MainStore>
    {
        public StoreContext()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UrbanShoes.DAL.MainStore context)
        {
            var categories = new List<Category>
            {
               /*1*/ new Category { Name = "Takkies" },
               /*2*/  new Category { Name = "Sneakers" },
               /*3*/ new Category { Name = "Loafers" },
               /*4*/ new Category { Name = "Boots" },
               /*5*/ new Category { Name= "Wedges" },
               /*6*/ new Category { Name= "Stlettos" },
               /*7*/ new Category { Name= "Ugg Boots" },
               /*8*/ new Category { Name= "Combat Boots" },
               /*9*/new Category { Name= "Flip Flops" },
               /*10*/new Category { Name= "High Heels" },
               /*11*/new Category { Name= "Golf Shoes" },
               /*12*/new Category { Name= "Jump Shoes" },
               /*13*/ new Category { Name= "Oxfords" },
               /*14*/new Category { Name= "Pumps" },
               /*15*/ new Category { Name= "Sandals" },
               /*16*/ new Category { Name= "Track Shoes" }

            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product { Name = "Jordan Takkies", Description="Comfortable and durable",Price=799, CategoryID=categories.Single( c => c.Name == "Takkies").ID },
               new Product { Name = "Black Combat Boots", Description="Rough, Tough look with striking dark features", Price=950, CategoryID=categories.Single( c => c.Name == "CombatBoots").ID },
                new Product { Name = "Ronnies Sneakers", Description="Comfortable and durable", Price= 799, CategoryID=categories.Single( c => c.Name == "Sneakers").ID  },
                new Product { Name = "Sandies Sliders", Description="Afforable in a range of colors", Price= 499, CategoryID=categories.Single( c => c.Name == "Sneakers").ID },
                new Product { Name = "Leelays", Description="Soft to touch, built to last", Price=499, CategoryID=categories.Single( c => c.Name == "Loafers").ID },
                new Product { Name = "Snookers", Description="Stress reliever for the feet", Price=599, CategoryID=categories.Single( c => c.Name == "Loafers").ID  },
               new Product { Name = "Bamins", Description="Sturdy and reliable", Price=500, CategoryID=categories.Single( c => c.Name == "Stlettos").ID  },
               new Product { Name = "Ball Walkers", Description="Highest Quality", Price=900, CategoryID=categories.Single( c => c.Name == "HighHeels").ID  },
               new Product { Name = "Froggies", Description="Breathable and easy to wash", Price=1100, CategoryID=categories.Single( c => c.Name == "Sandals").ID  },
               new Product { Name = "Yazz", Description="Bashfully elegant", Price=900, CategoryID=categories.Single( c => c.Name == "Oxfords").ID  },
               new Product { Name = "Kaufmann", Description="Fits a multiple of needs ", Price=1200, CategoryID=categories.Single( c => c.Name == "Jump Shoes").ID  },
               new Product { Name = "Krashin", Description="Comfort Shoes", Price=700, CategoryID= categories.Single( c => c.Name == "Boots").ID  },
               new Product { Name = "Stonies", Description="Can tackle any terrain", Price=600, CategoryID=categories.Single( c => c.Name == "Track Shoes").ID  },
               new Product { Name = "LeeKwai", Description="A magical shoe", Price=1500, CategoryID= categories.Single( c => c.Name == "Sandals").ID  },
               new Product { Name = "Bushmans", Description="Built for the bush", Price=900, CategoryID=categories.Single( c => c.Name == "Ugg Boots").ID  },
               new Product { Name = "Flayss", Description="Urban appeal", Price=1000, CategoryID=categories.Single( c => c.Name == "Wedges").ID  },
               new Product { Name = "Haymans", Description="5 Star Rating", Price=700, CategoryID=categories.Single( c => c.Name == "Oxfords").ID  }
               
           };

            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            
            var images = new List<ProductImage>
            {
                new ProductImage { FileName="Pshoe1.jpeg" },
                new ProductImage { FileName="Pshoe2.jpeg" },
                new ProductImage { FileName="Pshoe3.jpeg" },
                new ProductImage { FileName="Pshoe4.jpeg" },
                new ProductImage { FileName="Pshoe5.jpeg" },
                new ProductImage { FileName="Pshoe6.jpeg" },
        
                /*
                new ProductImage { FileName="Bottles2.JPG" },
                new ProductImage { FileName="Bottles3.JPG" },
                new ProductImage { FileName="Bibs1.JPG" },
                new ProductImage { FileName="Bibs2.JPG" },
                new ProductImage { FileName="Milk1.JPG" },
                new ProductImage { FileName="Nappies1.JPG" },
                new ProductImage { FileName="Nappies2.JPG" },
                new ProductImage { FileName="Nappies3.JPG" },
                new ProductImage { FileName="ColicMedicine1.JPG" },
                new ProductImage { FileName="Reflux1.JPG" },
                new ProductImage { FileName="Pram1.JPG" },
                new ProductImage { FileName="Pram2.JPG" },
                new ProductImage { FileName="Pram3.JPG" },
                new ProductImage { FileName="CarSeat1.JPG" },
                new ProductImage { FileName="CarSeat2.JPG" },
                new ProductImage { FileName="Moses1.JPG" },
                new ProductImage { FileName="Moses2.JPG" },
                new ProductImage { FileName="Crib1.JPG" },
                new ProductImage { FileName="Crib2.JPG" },
                new ProductImage { FileName="Bed1.JPG" },
                new ProductImage { FileName="Bed2.JPG" },
                new ProductImage { FileName="CircusBale1.JPG" },
                new ProductImage { FileName="CircusBale2.JPG" },
                new ProductImage { FileName="CircusBale3.JPG" },
                new ProductImage { FileName="LovedBale1.JPG" },
                */
            };

            images.ForEach(c => context.ProductImages.AddOrUpdate(p => p.FileName, c));
            context.SaveChanges();
            /*

            var imageMappings = new List<ProductImageMapping>
            {
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "SleepSuit1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Sleep Suit").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "SleepSuit2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Sleep Suit").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Vest1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Vest").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Vest2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Vest").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Lion1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Orange and Yellow Lion").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Rabbit1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Blue Rabbit").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bottles1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "3 Pack of Bottles").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bottles2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "3 Pack of Bottles").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bottles3.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "3 Pack of Bottles").ID, ImageNumber = 2 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bibs1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "3 Pack of Bibs").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bibs2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "3 Pack of Bibs").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Milk1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Powdered Baby Milk").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Nappies1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Pack of 70 Disposable Nappies").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Nappies2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Pack of 70 Disposable Nappies").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Nappies3.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Pack of 70 Disposable Nappies").ID, ImageNumber = 2 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "ColicMedicine1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Colic Medicine").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Reflux1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Reflux Medicine").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Pram1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Black Pram and Pushchair System").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Pram2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Black Pram and Pushchair System").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Pram3.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Black Pram and Pushchair System").ID, ImageNumber = 2 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "CarSeat1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Car Seat").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "CarSeat2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Car Seat").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Moses1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Moses Basket").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Moses2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Moses Basket").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Crib1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Crib").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Crib2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Crib").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bed1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Cot Bed").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "Bed2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Cot Bed").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "CircusBale1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Circus Crib Bale").ID, ImageNumber = 0 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "CircusBale2.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Circus Crib Bale").ID, ImageNumber = 1 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "CircusBale3.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Circus Crib Bale").ID, ImageNumber = 2 },
                new ProductImageMapping { ProductImageID= images.Single(i => i.FileName == "LovedBale1.JPG").ID,
                    ProductID = products.Single( c=> c.Name == "Loved Crib Bale").ID, ImageNumber = 0 },
            };

            imageMappings.ForEach(c => context.ProductImageMappings.AddOrUpdate(im => im.ProductImageID, c));
            context.SaveChanges();  */



        }
    }
}