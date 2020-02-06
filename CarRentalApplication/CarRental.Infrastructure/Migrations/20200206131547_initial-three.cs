using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HorsePower", "LicensePlate", "Model" },
                values: new object[] { 140, "ASD123", "V90" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HorsePower", "LicensePlate", "Model" },
                values: new object[] { 200, "SAD123", "A3" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HorsePower", "LicensePlate", "Model" },
                values: new object[] { 240, "BLA773", "M5" });

            migrationBuilder.UpdateData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Manufacturer",
                value: "Volvo");

            migrationBuilder.UpdateData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Manufacturer",
                value: "Audi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HorsePower", "LicensePlate", "Model" },
                values: new object[] { 1337, "asd123", "BMW" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HorsePower", "LicensePlate", "Model" },
                values: new object[] { 1337, "asd123", "Vovlo" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HorsePower", "LicensePlate", "Model" },
                values: new object[] { 1337, "asd123", "Vovlo" });

            migrationBuilder.UpdateData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Manufacturer",
                value: "Hassan AB");

            migrationBuilder.UpdateData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Manufacturer",
                value: "Volvo");
        }
    }
}
