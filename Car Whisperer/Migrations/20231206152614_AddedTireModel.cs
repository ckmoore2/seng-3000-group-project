using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Whisperer.Migrations
{
    /// <inheritdoc />
    public partial class AddedTireModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "ProductPrice");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "ProductCategoryId");

            migrationBuilder.CreateTable(
                name: "Tires",
                columns: table => new
                {
                    TireId = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TireName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TirePrice = table.Column<float>(type: "REAL", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tires", x => x.TireId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tires");

            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "Products",
                newName: "CategoryId");
        }
    }
}
