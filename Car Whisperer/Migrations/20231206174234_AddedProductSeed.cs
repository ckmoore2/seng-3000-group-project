using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Whisperer.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tires",
                table: "Tires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Tires",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "TireId",
                table: "Tires",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Products",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tires",
                table: "Tires",
                column: "ProductCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCategoryId", "ProductId", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 1, "Whisper Tire Set", 600f },
                    { 2, 2, "Whisper Brake Set", 280f },
                    { 3, 3, "Whisper Car Battery", 130f },
                    { 4, 4, "Whisper Motor Oil - Synthetic", 25f },
                    { 5, 5, "Whisper Wipers", 7f }
                });

            migrationBuilder.InsertData(
                table: "Tires",
                columns: new[] { "ProductCategoryId", "TireId", "TireName", "TirePrice" },
                values: new object[,]
                {
                    { 1, 1, "Michelin", 180f },
                    { 2, 2, "Goodyear", 189.99f },
                    { 3, 3, "Bridgestone", 163.99f },
                    { 4, 4, "Pirelli", 158.99f },
                    { 5, 5, "Continental", 264.99f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tires",
                table: "Tires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "ProductCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "ProductCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "ProductCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "ProductCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tires",
                keyColumn: "ProductCategoryId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "TireId",
                table: "Tires",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Tires",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Products",
                type: "INTEGER",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 50)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tires",
                table: "Tires",
                column: "TireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");
        }
    }
}
