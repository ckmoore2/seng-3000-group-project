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

        public DbSet<Battery> Batteries {get; set; } = null!;

        public DbSet<Oil> Oils {get; set; } = null!;

        public DbSet<Wiper> Wipers {get; set; } = null!;


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
                new Oil {OilCategoryId = 5, OilId = 5, OilName = "FRAM Full Synthetic 5W-30", OilPrice = 29.99f},

            );

            modelBuilder.Entity<Wiper>().HasData(
                new Wiper {WiperCategoryId = 1, WiperId = 1, WiperName = "Rain-X Silicone AdvantEdge 22in Beam", WiperPrice 39.99f},
                new Wiper {WiperCategoryId = 2, WiperId = 2, WiperName = "PIAA Super Silicone 24in", WiperPrice 25.99f},
                new Wiper {WiperCategoryId = 3, WiperId = 3, WiperName = "TRICO Exact Fit 22in", WiperPrice 8.99f},
                new Wiper {WiperCategoryId = 4, WiperId = 4, WiperName = "BOSCH 22OE ICON Premium Beam", WiperPrice 25.99f},
                new Wiper {WiperCategoryId = 5, WiperId = 5, WiperName = "Rain-X WeatherBeater 22in", WiperPrice 26.99f},


            );

        }
    }

