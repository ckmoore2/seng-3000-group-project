using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Whisperer.Migrations
{
    /// <inheritdoc />
    public partial class AddedControllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "Tires",
                newName: "TireCategoryId");

            migrationBuilder.CreateTable(
                name: "Brakes",
                columns: table => new
                {
                    BrakeCategoryId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrakeId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    BrakeName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    BrakePrice = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brakes", x => x.BrakeCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Car Batteries",
                columns: table => new
                {
                    BatteryCategoryId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BatteryId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    BatteryName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    BatteryPrice = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car Batteries", x => x.BatteryCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Oil",
                columns: table => new
                {
                    OilCategoryId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OilId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    OilName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    OilPrice = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oil", x => x.OilCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTire",
                columns: table => new
                {
                    ProductsProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    TiresTireCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTire", x => new { x.ProductsProductCategoryId, x.TiresTireCategoryId });
                    table.ForeignKey(
                        name: "FK_ProductTire_Products_ProductsProductCategoryId",
                        column: x => x.ProductsProductCategoryId,
                        principalTable: "Products",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTire_Tires_TiresTireCategoryId",
                        column: x => x.TiresTireCategoryId,
                        principalTable: "Tires",
                        principalColumn: "TireCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Wipers",
                columns: table => new
                {
                    WiperCategoryId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WiperId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    WiperName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    WiperPrice = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wipers", x => x.WiperCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BrakeProduct",
                columns: table => new
                {
                    BrakesBrakeCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrakeProduct", x => new { x.BrakesBrakeCategoryId, x.ProductsProductCategoryId });
                    table.ForeignKey(
                        name: "FK_BrakeProduct_Brakes_BrakesBrakeCategoryId",
                        column: x => x.BrakesBrakeCategoryId,
                        principalTable: "Brakes",
                        principalColumn: "BrakeCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrakeProduct_Products_ProductsProductCategoryId",
                        column: x => x.ProductsProductCategoryId,
                        principalTable: "Products",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BatteryProduct",
                columns: table => new
                {
                    BatteriesBatteryCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryProduct", x => new { x.BatteriesBatteryCategoryId, x.ProductsProductCategoryId });
                    table.ForeignKey(
                        name: "FK_BatteryProduct_Car Batteries_BatteriesBatteryCategoryId",
                        column: x => x.BatteriesBatteryCategoryId,
                        principalTable: "Car Batteries",
                        principalColumn: "BatteryCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatteryProduct_Products_ProductsProductCategoryId",
                        column: x => x.ProductsProductCategoryId,
                        principalTable: "Products",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OilProduct",
                columns: table => new
                {
                    OilsOilCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilProduct", x => new { x.OilsOilCategoryId, x.ProductsProductCategoryId });
                    table.ForeignKey(
                        name: "FK_OilProduct_Oil_OilsOilCategoryId",
                        column: x => x.OilsOilCategoryId,
                        principalTable: "Oil",
                        principalColumn: "OilCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilProduct_Products_ProductsProductCategoryId",
                        column: x => x.ProductsProductCategoryId,
                        principalTable: "Products",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineItems",
                columns: table => new
                {
                    LineItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    LineNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    LineTotal = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItems", x => x.LineItemId);
                    table.ForeignKey(
                        name: "FK_LineItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    PasswordSalt = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductWiper",
                columns: table => new
                {
                    ProductsProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    WipersWiperCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWiper", x => new { x.ProductsProductCategoryId, x.WipersWiperCategoryId });
                    table.ForeignKey(
                        name: "FK_ProductWiper_Products_ProductsProductCategoryId",
                        column: x => x.ProductsProductCategoryId,
                        principalTable: "Products",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductWiper_Wipers_WipersWiperCategoryId",
                        column: x => x.WipersWiperCategoryId,
                        principalTable: "Wipers",
                        principalColumn: "WiperCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brakes",
                columns: new[] { "BrakeCategoryId", "BrakeId", "BrakeName", "BrakePrice" },
                values: new object[,]
                {
                    { 1, 1, "Carquest Ceramic Brake Pads", 74.99f },
                    { 2, 2, "Carquest Painted Brake Rotor", 86.99f },
                    { 3, 3, "Carquest Professional Brake Pads", 73.99f },
                    { 4, 4, "Carquest Wearever Brake Rotor", 80.99f },
                    { 5, 5, "Carquest Brake Parts Cleaner", 5.99f }
                });

            migrationBuilder.InsertData(
                table: "Car Batteries",
                columns: new[] { "BatteryCategoryId", "BatteryId", "BatteryName", "BatteryPrice" },
                values: new object[,]
                {
                    { 1, 1, "Stinger SPP2150 Dry Cell", 545.99f },
                    { 2, 2, "Everstart Value Lead Acid 26R-540", 140f },
                    { 3, 3, "Traveller 34 BCI", 149.99f },
                    { 4, 4, "DieHard Red Battery", 151.99f },
                    { 5, 5, "Duralast Gold", 209.99f }
                });

            migrationBuilder.InsertData(
                table: "Oil",
                columns: new[] { "OilCategoryId", "OilId", "OilName", "OilPrice" },
                values: new object[,]
                {
                    { 1, 1, "Mobil 1 Advanced Full Synthetic", 37.99f },
                    { 2, 2, "LIQUI MOLY HighTech Full Synthetic", 49.99f },
                    { 3, 3, "Valvoline Advanced Full Synthetic", 36.99f },
                    { 4, 4, "Castrol EDGE High Mileage 5W-30 Advanced Full Synthetic", 40.99f },
                    { 5, 5, "FRAM Full Synthetic 5W-30", 29.99f }
                });

            migrationBuilder.InsertData(
                table: "Wipers",
                columns: new[] { "WiperCategoryId", "WiperId", "WiperName", "WiperPrice" },
                values: new object[,]
                {
                    { 1, 1, "Rain-X Silicone AdvantEdge 22in Beam", 39.99f },
                    { 2, 2, "PIAA Super Silicone 24in", 25.99f },
                    { 3, 3, "TRICO Exact Fit 22in", 8.99f },
                    { 4, 4, "BOSCH 22OE ICON Premium Beam", 25.99f },
                    { 5, 5, "Rain-X WeatherBeater 22in", 26.99f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryProduct_ProductsProductCategoryId",
                table: "BatteryProduct",
                column: "ProductsProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BrakeProduct_ProductsProductCategoryId",
                table: "BrakeProduct",
                column: "ProductsProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_OrderId",
                table: "LineItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OilProduct_ProductsProductCategoryId",
                table: "OilProduct",
                column: "ProductsProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTire_TiresTireCategoryId",
                table: "ProductTire",
                column: "TiresTireCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductWiper_WipersWiperCategoryId",
                table: "ProductWiper",
                column: "WipersWiperCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatteryProduct");

            migrationBuilder.DropTable(
                name: "BrakeProduct");

            migrationBuilder.DropTable(
                name: "LineItems");

            migrationBuilder.DropTable(
                name: "OilProduct");

            migrationBuilder.DropTable(
                name: "ProductTire");

            migrationBuilder.DropTable(
                name: "ProductWiper");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Car Batteries");

            migrationBuilder.DropTable(
                name: "Brakes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Oil");

            migrationBuilder.DropTable(
                name: "Wipers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.RenameColumn(
                name: "TireCategoryId",
                table: "Tires",
                newName: "ProductCategoryId");
        }
    }
}
