using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Whisperer.Migrations
{
    /// <inheritdoc />
    public partial class AddedTokenController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Manage" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "RoleId" },
                values: new object[,]
                {
                    { 1, "moorecu17@students.ecu.edu", "Student", "User", "AB87239A9588C24ADD3F12DC51D1092B59AF4CF21701595071E847E7E782C147A1B65C728A44B6FCFDEE0173E06EE4FC7DE2776A334B71DA8D54104DB117B5BB", "E369AA71D63911D8BFD40B060DD3CF7BC24BAC402C52169B59DBA195B3252CBD35BABB9E74DCA029CECFD7F70A8F4A06F7ADEA6B693A71764677DDE6FD7C914A", 1 },
                    { 2, "curtis.k.moore2@gmail.com", "Curtis", "Moore", "AF40AB4766BB503A86CDB18243DAD9F70EB16D861438407B3FEF0985B4E2FA922B391B5AE120D5727778C75682A4299D70F517093F7726FCCE2F527FA76CA106", "CED5E0C3E314537BE082DEA411258579246D19CEAA3C7801654490CBF31453A9561DE5F643F89BF9CA6CD1ABC2C42BF5C8C39D1CF977F5D419D6CBC04C140A88", 2 },
                    { 3, "brown.landon@outlook.com", "Landon", "Brown", "2247E6B655BE3085D33B3052F4FDC9ADEC13B8FBA8339AA17E0375EC7AC2DE70CCA458C53D45FA8739A2E986BD9A7C16E559913DD257389B1A9AAFA87595C562", "432CD4A19D19337DF0CFD443357FC473C1CC1F62F45B3EE870339A835D13317A315C2E231EB43CA939127123D27F0DC81C0F9A21CB80406BE27570BDACD19AB0", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);
        }
    }
}
