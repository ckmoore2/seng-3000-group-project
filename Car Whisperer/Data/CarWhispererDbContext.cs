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

        public DbSet<Product> Products { get; set; } 

        public DbSet<Tire> Tires { get; set; } 

        public DbSet<Brake> Brakes { get; set; } 

        public DbSet<Battery> Batteries {get; set; }

        public DbSet<Oil> Oils {get; set; }

        public DbSet<Wiper> Wipers {get; set; } 

        public DbSet<Order> Orders { get; set; }

        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<User> Users { get;  set; }

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

            modelBuilder.Entity<Battery>().HasData(
                new Battery {BatteryCategoryId = 1, BatteryId = 1, BatteryName = "Stinger SPP2150 Dry Cell", BatteryPrice = 545.99f },
                new Battery {BatteryCategoryId = 2, BatteryId = 2, BatteryName = "Everstart Value Lead Acid 26R-540", BatteryPrice = 140.00f },
                new Battery {BatteryCategoryId = 3, BatteryId = 3, BatteryName = "Traveller 34 BCI", BatteryPrice = 149.99f },
                new Battery {BatteryCategoryId = 4, BatteryId = 4, BatteryName = "DieHard Red Battery", BatteryPrice = 151.99f },
                new Battery {BatteryCategoryId = 5, BatteryId = 5, BatteryName = "Duralast Gold", BatteryPrice = 209.99f }


            );

            modelBuilder.Entity<Oil>().HasData(
                new Oil {OilCategoryId = 1, OilId = 1, OilName = "Mobil 1 Advanced Full Synthetic", OilPrice = 37.99f},
                new Oil {OilCategoryId = 2, OilId = 2, OilName = "LIQUI MOLY HighTech Full Synthetic", OilPrice = 49.99f},
                new Oil {OilCategoryId = 3, OilId = 3, OilName = "Valvoline Advanced Full Synthetic", OilPrice = 36.99f},
                new Oil {OilCategoryId = 4, OilId = 4, OilName = "Castrol EDGE High Mileage 5W-30 Advanced Full Synthetic", OilPrice = 40.99f},
                new Oil {OilCategoryId = 5, OilId = 5, OilName = "FRAM Full Synthetic 5W-30", OilPrice = 29.99f}

            );

            modelBuilder.Entity<Wiper>().HasData(
                new Wiper {WiperCategoryId = 1, WiperId = 1, WiperName = "Rain-X Silicone AdvantEdge 22in Beam", WiperPrice = 39.99f},
                new Wiper {WiperCategoryId = 2, WiperId = 2, WiperName = "PIAA Super Silicone 24in", WiperPrice = 25.99f},
                new Wiper {WiperCategoryId = 3, WiperId = 3, WiperName = "TRICO Exact Fit 22in", WiperPrice = 8.99f},
                new Wiper {WiperCategoryId = 4, WiperId = 4, WiperName = "BOSCH 22OE ICON Premium Beam", WiperPrice = 25.99f},
                new Wiper {WiperCategoryId = 5, WiperId = 5, WiperName = "Rain-X WeatherBeater 22in", WiperPrice = 26.99f}


            );

            modelBuilder.Entity<Role>().HasData(
                new Role{RoleId=1,RoleName="Admin"},
                new Role{RoleId=2,RoleName="User"},
                new Role{RoleId=3,RoleName="Manage"}               
            );

            modelBuilder.Entity<User>().HasData(
                new User{UserId=1,Email="moorecu17@students.ecu.edu",FirstName="Student",LastName="User",RoleId=1,PasswordHash="AB87239A9588C24ADD3F12DC51D1092B59AF4CF21701595071E847E7E782C147A1B65C728A44B6FCFDEE0173E06EE4FC7DE2776A334B71DA8D54104DB117B5BB",PasswordSalt="E369AA71D63911D8BFD40B060DD3CF7BC24BAC402C52169B59DBA195B3252CBD35BABB9E74DCA029CECFD7F70A8F4A06F7ADEA6B693A71764677DDE6FD7C914A"},
                new User{UserId=2,Email="curtis.k.moore2@gmail.com",FirstName="Curtis",LastName="Moore",RoleId=2,PasswordHash="AF40AB4766BB503A86CDB18243DAD9F70EB16D861438407B3FEF0985B4E2FA922B391B5AE120D5727778C75682A4299D70F517093F7726FCCE2F527FA76CA106",PasswordSalt="CED5E0C3E314537BE082DEA411258579246D19CEAA3C7801654490CBF31453A9561DE5F643F89BF9CA6CD1ABC2C42BF5C8C39D1CF977F5D419D6CBC04C140A88"}
            );


            
        }

}