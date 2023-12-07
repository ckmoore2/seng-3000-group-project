﻿// <auto-generated />
using System;
using Car_Whisperer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Whisperer.Migrations
{
    [DbContext(typeof(CarWhispererDbContext))]
    [Migration("20231207070152_AddedControllers")]
    partial class AddedControllers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("BatteryProduct", b =>
                {
                    b.Property<int>("BatteriesBatteryCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductsProductCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BatteriesBatteryCategoryId", "ProductsProductCategoryId");

                    b.HasIndex("ProductsProductCategoryId");

                    b.ToTable("BatteryProduct");
                });

            modelBuilder.Entity("BrakeProduct", b =>
                {
                    b.Property<int>("BrakesBrakeCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductsProductCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BrakesBrakeCategoryId", "ProductsProductCategoryId");

                    b.HasIndex("ProductsProductCategoryId");

                    b.ToTable("BrakeProduct");
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Battery", b =>
                {
                    b.Property<int>("BatteryCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<int>("BatteryId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("BatteryName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("BatteryPrice")
                        .HasColumnType("REAL");

                    b.HasKey("BatteryCategoryId");

                    b.ToTable("Car Batteries");

                    b.HasData(
                        new
                        {
                            BatteryCategoryId = 1,
                            BatteryId = 1,
                            BatteryName = "Stinger SPP2150 Dry Cell",
                            BatteryPrice = 545.99f
                        },
                        new
                        {
                            BatteryCategoryId = 2,
                            BatteryId = 2,
                            BatteryName = "Everstart Value Lead Acid 26R-540",
                            BatteryPrice = 140f
                        },
                        new
                        {
                            BatteryCategoryId = 3,
                            BatteryId = 3,
                            BatteryName = "Traveller 34 BCI",
                            BatteryPrice = 149.99f
                        },
                        new
                        {
                            BatteryCategoryId = 4,
                            BatteryId = 4,
                            BatteryName = "DieHard Red Battery",
                            BatteryPrice = 151.99f
                        },
                        new
                        {
                            BatteryCategoryId = 5,
                            BatteryId = 5,
                            BatteryName = "Duralast Gold",
                            BatteryPrice = 209.99f
                        });
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Brake", b =>
                {
                    b.Property<int>("BrakeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrakeId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrakeName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("BrakePrice")
                        .HasColumnType("REAL");

                    b.HasKey("BrakeCategoryId");

                    b.ToTable("Brakes");

                    b.HasData(
                        new
                        {
                            BrakeCategoryId = 1,
                            BrakeId = 1,
                            BrakeName = "Carquest Ceramic Brake Pads",
                            BrakePrice = 74.99f
                        },
                        new
                        {
                            BrakeCategoryId = 2,
                            BrakeId = 2,
                            BrakeName = "Carquest Painted Brake Rotor",
                            BrakePrice = 86.99f
                        },
                        new
                        {
                            BrakeCategoryId = 3,
                            BrakeId = 3,
                            BrakeName = "Carquest Professional Brake Pads",
                            BrakePrice = 73.99f
                        },
                        new
                        {
                            BrakeCategoryId = 4,
                            BrakeId = 4,
                            BrakeName = "Carquest Wearever Brake Rotor",
                            BrakePrice = 80.99f
                        },
                        new
                        {
                            BrakeCategoryId = 5,
                            BrakeId = 5,
                            BrakeName = "Carquest Brake Parts Cleaner",
                            BrakePrice = 5.99f
                        });
                });

            modelBuilder.Entity("Car_Whisperer.Entities.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LineNumber")
                        .HasColumnType("INTEGER");

                    b.Property<float>("LineTotal")
                        .HasColumnType("REAL");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Oil", b =>
                {
                    b.Property<int>("OilCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<int>("OilId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("OilName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("OilPrice")
                        .HasColumnType("REAL");

                    b.HasKey("OilCategoryId");

                    b.ToTable("Oil");

                    b.HasData(
                        new
                        {
                            OilCategoryId = 1,
                            OilId = 1,
                            OilName = "Mobil 1 Advanced Full Synthetic",
                            OilPrice = 37.99f
                        },
                        new
                        {
                            OilCategoryId = 2,
                            OilId = 2,
                            OilName = "LIQUI MOLY HighTech Full Synthetic",
                            OilPrice = 49.99f
                        },
                        new
                        {
                            OilCategoryId = 3,
                            OilId = 3,
                            OilName = "Valvoline Advanced Full Synthetic",
                            OilPrice = 36.99f
                        },
                        new
                        {
                            OilCategoryId = 4,
                            OilId = 4,
                            OilName = "Castrol EDGE High Mileage 5W-30 Advanced Full Synthetic",
                            OilPrice = 40.99f
                        },
                        new
                        {
                            OilCategoryId = 5,
                            OilId = 5,
                            OilName = "FRAM Full Synthetic 5W-30",
                            OilPrice = 29.99f
                        });
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Product", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("ProductPrice")
                        .HasColumnType("REAL");

                    b.HasKey("ProductCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductCategoryId = 1,
                            ProductId = 1,
                            ProductName = "Whisper Tire Set",
                            ProductPrice = 600f
                        },
                        new
                        {
                            ProductCategoryId = 2,
                            ProductId = 2,
                            ProductName = "Whisper Brake Set",
                            ProductPrice = 280f
                        },
                        new
                        {
                            ProductCategoryId = 3,
                            ProductId = 3,
                            ProductName = "Whisper Car Battery",
                            ProductPrice = 130f
                        },
                        new
                        {
                            ProductCategoryId = 4,
                            ProductId = 4,
                            ProductName = "Whisper Motor Oil - Synthetic",
                            ProductPrice = 25f
                        },
                        new
                        {
                            ProductCategoryId = 5,
                            ProductId = 5,
                            ProductName = "Whisper Wipers",
                            ProductPrice = 7f
                        });
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Tire", b =>
                {
                    b.Property<int>("TireCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<int>("TireId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("TireName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("TirePrice")
                        .HasColumnType("REAL");

                    b.HasKey("TireCategoryId");

                    b.ToTable("Tires");

                    b.HasData(
                        new
                        {
                            TireCategoryId = 1,
                            TireId = 1,
                            TireName = "Michelin",
                            TirePrice = 180f
                        },
                        new
                        {
                            TireCategoryId = 2,
                            TireId = 2,
                            TireName = "Goodyear",
                            TirePrice = 189.99f
                        },
                        new
                        {
                            TireCategoryId = 3,
                            TireId = 3,
                            TireName = "Bridgestone",
                            TirePrice = 163.99f
                        },
                        new
                        {
                            TireCategoryId = 4,
                            TireId = 4,
                            TireName = "Pirelli",
                            TirePrice = 158.99f
                        },
                        new
                        {
                            TireCategoryId = 5,
                            TireId = 5,
                            TireName = "Continental",
                            TirePrice = 264.99f
                        });
                });

            modelBuilder.Entity("Car_Whisperer.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Wiper", b =>
                {
                    b.Property<int>("WiperCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<int>("WiperId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("WiperName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("WiperPrice")
                        .HasColumnType("REAL");

                    b.HasKey("WiperCategoryId");

                    b.ToTable("Wipers");

                    b.HasData(
                        new
                        {
                            WiperCategoryId = 1,
                            WiperId = 1,
                            WiperName = "Rain-X Silicone AdvantEdge 22in Beam",
                            WiperPrice = 39.99f
                        },
                        new
                        {
                            WiperCategoryId = 2,
                            WiperId = 2,
                            WiperName = "PIAA Super Silicone 24in",
                            WiperPrice = 25.99f
                        },
                        new
                        {
                            WiperCategoryId = 3,
                            WiperId = 3,
                            WiperName = "TRICO Exact Fit 22in",
                            WiperPrice = 8.99f
                        },
                        new
                        {
                            WiperCategoryId = 4,
                            WiperId = 4,
                            WiperName = "BOSCH 22OE ICON Premium Beam",
                            WiperPrice = 25.99f
                        },
                        new
                        {
                            WiperCategoryId = 5,
                            WiperId = 5,
                            WiperName = "Rain-X WeatherBeater 22in",
                            WiperPrice = 26.99f
                        });
                });

            modelBuilder.Entity("OilProduct", b =>
                {
                    b.Property<int>("OilsOilCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductsProductCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OilsOilCategoryId", "ProductsProductCategoryId");

                    b.HasIndex("ProductsProductCategoryId");

                    b.ToTable("OilProduct");
                });

            modelBuilder.Entity("ProductTire", b =>
                {
                    b.Property<int>("ProductsProductCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TiresTireCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductsProductCategoryId", "TiresTireCategoryId");

                    b.HasIndex("TiresTireCategoryId");

                    b.ToTable("ProductTire");
                });

            modelBuilder.Entity("ProductWiper", b =>
                {
                    b.Property<int>("ProductsProductCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WipersWiperCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductsProductCategoryId", "WipersWiperCategoryId");

                    b.HasIndex("WipersWiperCategoryId");

                    b.ToTable("ProductWiper");
                });

            modelBuilder.Entity("BatteryProduct", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Battery", null)
                        .WithMany()
                        .HasForeignKey("BatteriesBatteryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Whisperer.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrakeProduct", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Brake", null)
                        .WithMany()
                        .HasForeignKey("BrakesBrakeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Whisperer.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Whisperer.Entities.LineItem", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Order", null)
                        .WithMany("LineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Whisperer.Entities.User", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("OilProduct", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Oil", null)
                        .WithMany()
                        .HasForeignKey("OilsOilCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Whisperer.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductTire", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Whisperer.Entities.Tire", null)
                        .WithMany()
                        .HasForeignKey("TiresTireCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductWiper", b =>
                {
                    b.HasOne("Car_Whisperer.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Whisperer.Entities.Wiper", null)
                        .WithMany()
                        .HasForeignKey("WipersWiperCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Whisperer.Entities.Order", b =>
                {
                    b.Navigation("LineItems");
                });
#pragma warning restore 612, 618
        }
    }
}