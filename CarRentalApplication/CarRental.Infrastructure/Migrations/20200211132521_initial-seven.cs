using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialseven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MemberCard",
                columns: new[] { "Id", "QrCode" },
                values: new object[] { 3, 125 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MemberCard",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
