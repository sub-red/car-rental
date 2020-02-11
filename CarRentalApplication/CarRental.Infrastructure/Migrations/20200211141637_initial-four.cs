using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MemberCard",
                columns: new[] { "Id", "MemberStatus" },
                values: new object[] { 3, "Suspended, pending investigation" });

            migrationBuilder.InsertData(
                table: "MemberCard",
                columns: new[] { "Id", "MemberStatus" },
                values: new object[] { 4, "Permanently banned" });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Adress", "Age", "DriversLicense", "FirstName", "LastName", "MemberCardId" },
                values: new object[] { 3, "Prinsgatan 1", 55, 2211, "Johan", "Johansson", 3 });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Adress", "Age", "DriversLicense", "FirstName", "LastName", "MemberCardId" },
                values: new object[] { 4, "Prinsessgatan 1", 12, 2212, "Anders", "Andersson", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MemberCard",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MemberCard",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
