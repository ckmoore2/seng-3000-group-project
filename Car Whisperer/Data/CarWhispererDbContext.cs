using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_Whisperer;
using Car_Whisperer.Entities;
using  Car_Whisperer.Controllers;

namespace Car_Whisperer.Data;

public class CarWhispererDbContext : DbContext
    {
        public CarWhispererDbContext (DbContextOptions<CarWhispererDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Tire> Tires { get; set; } = null!;

        public DbSet<Brake> Brakes { get; set; } = null!;

        public DbSet<Oil> Oils { get; set; } = null!;

        public DbSet<Wiper> Wipers { get; set; } = null!;
        
        public DbSet<Battery> Batteries { get; set; } = null!;

        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductCategoryId = 1, ProductId = 001, ProductName = "Whisper Tire Set", ProductPrice = 600.00f},
                new Product { ProductCategoryId = 2, ProductId = 002, ProductName = "Whisper Brake Set", ProductPrice = 280.00f},
                new Product { ProductCategoryId = 3, ProductId = 003, ProductName = "Whisper Car Battery", ProductPrice = 130.00f},
                new Product { ProductCategoryId = 4, ProductId = 004, ProductName = "Whisper Motor Oil - Synthetic", ProductPrice = 25.00f},
                new Product { ProductCategoryId = 5, ProductId = 005, ProductName = "Whisper Wipers", ProductPrice = 7.00f}
            );

            modelBuilder.Entity<Tire>().HasData(
                new Tire { TireCategoryId = 1, TireId = 1, TireName = "Michelin", TirePrice = 180.00f},
                new Tire { TireCategoryId = 2, TireId = 2, TireName = "Goodyear", TirePrice = 189.99f},
                new Tire { TireCategoryId = 3, TireId = 3, TireName = "Bridgestone", TirePrice = 163.99f},
                new Tire { TireCategoryId = 4, TireId = 4, TireName = "Pirelli", TirePrice = 158.990f},
                new Tire { TireCategoryId = 5, TireId = 5, TireName = "Continental", TirePrice = 264.99f}
            );

            modelBuilder.Entity<Brake>().HasData(
                new Brake { BrakeCategoryId = 1, BrakeId = 1, BrakeName = "Carquest Ceramic Brake Pads", BrakePrice = 74.99f},
                new Brake { BrakeCategoryId = 2, BrakeId = 2, BrakeName = "Carquest Painted Brake Rotor", BrakePrice = 86.99f},
                new Brake { BrakeCategoryId = 3, BrakeId = 3, BrakeName = "Carquest Professional Brake Pads", BrakePrice = 73.99f},
                new Brake { BrakeCategoryId = 4, BrakeId = 4, BrakeName = "Carquest Wearever Brake Rotor", BrakePrice = 80.990f},
                new Brake { BrakeCategoryId = 5, BrakeId = 5, BrakeName = "Carquest Brake Parts Cleaner", BrakePrice = 5.99f}
            );

            modelBuilder.Entity<Role>().HasData(
                new Role{RoleId=1,RoleName="Admin"},
                new Role{RoleId=2,RoleName="User"},
                new Role{RoleId=3,RoleName="Manage"}
            );



        }
    }

