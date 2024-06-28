﻿
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrientalOasis.Model;
using Microsoft.AspNetCore.Identity;
namespace OrientalOasis.DataAccess.Data
{
    //config for entity Framework core
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        //constructor for the class and config the DbContentOptions for the class and the options wiill be passed to the class DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }
        //create database set for the table, then go to Tools-NuGet Manager Console and type 'add-migration AddCategoryTableToDb'.
        //This will create another file if there is a primary key defined in Category.cs and use data annotation [key]
        public DbSet <Category>Categories { get; set; }
        public DbSet<Product> Products{ get; set; } //define a Product table
        public DbSet<ApplicationUser> ApplicationUsers {  get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart>ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        //override the default func that generated by the model.( ModelBuilder is default by the entiry framework)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //must add this line when using Identity
            base.OnModelCreating(modelBuilder);


            //override the default behavior by create entity objects which defined in Category.cs.
            //this tells the Entiry Framework to create these records
            modelBuilder.Entity<Category>().HasData(
                new Category { Cat_Id = 1, Name = "Ceramics", DisplayOrder = 1 },
                new Category { Cat_Id = 2, Name = "Paintings", DisplayOrder = 2 },
                new Category { Cat_Id = 3, Name = "Sculptures", DisplayOrder = 3 }

                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Elegant Ceramics", StreetAddress = "123 Pottery Lane", City = "Springfield", State = "IL", PostalCode = "62701", PhoneNumber = "217-555-1234" },
                new Company { Id = 2, Name = "Artistic Sculptures", StreetAddress = "456 Sculpture Blvd", City = "Denver", State = "CO", PostalCode = "80202", PhoneNumber = "303-555-5678" },
                new Company { Id = 3, Name = "Oriental Paintings", StreetAddress = "789 Art Street", City = "San Francisco", State = "CA", PostalCode = "94102", PhoneNumber = "415-555-9101" }
                );


            //seed the products table
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Cat_Id = 1,
                    ItemName = "Fortune of Time",
                    Origin = "Indian",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ItemNumber = "SWD9999001",                  
                    ListPrice = 99,
                    Price = 85,
                    Price50 = 80,
                    Price100 = 50,
                    ProductId = 1,
                    ImageURL=""
                   
                },
                new Product
                {
                    Cat_Id = 2,                   
                    ItemName = "Nancy Hoover",
                    Origin = "ThaiLand",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ItemNumber = "CAW777777701",                  
                    ListPrice = 40,                   
                    Price = 25,
                    Price50 = 20,
                    Price100 = 15,
                    ProductId = 2,
                    ImageURL = ""

                },
                new Product
                {
                    Cat_Id = 3,                 
                    ItemName = "Vanish in the Sunset",
                    Origin = "VietName",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ItemNumber = "RITO5555501",                  
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    ProductId = 3,
                    ImageURL = ""

                },
                new Product
                {
                    Cat_Id = 1,
                    ItemName = "Cotton Candy",                 
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ItemNumber = "WS3333333301",
                    Origin = "China",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    ProductId = 4,
                    ImageURL = ""

                },
                new Product
                {
                    Cat_Id = 2,
                    ItemName = "Rock in the Ocean",
                    Origin = "Indonesia",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ItemNumber = "SOTJ1111111101",                  
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,                   
                    ProductId = 5,
                    ImageURL = ""
                },
                new Product
                {
                    Cat_Id = 3,                  
                    ItemName = "Leaves and Wonders",
                    Origin = "Laura Phantom",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ItemNumber = "FOT000000001",                   
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    ProductId = 6,
                    ImageURL = ""


                }


                );

        }
    }
}
