using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "Silver");

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "Black");

            migrationBuilder.InsertData(
                table: "CarManufacturers",
                columns: new[] { "Id", "Manufacturer" },
                values: new object[,]
                {
                    { 4, "Skoda" },
                    { 5, "Toyota" },
                    { 6, "Saab" },
                    { 7, "Volkswagen" },
                    { 8, "Hyundai" },
                    { 9, "Lada" },
                    { 10, "Ferrari" }
                });

            migrationBuilder.InsertData(
                table: "CarDetails",
                columns: new[] { "Id", "Color", "HorsePower", "LicensePlate", "ManufacturerId", "Model", "Price" },
                values: new object[,]
                {
                    { 4, "Blue", 100, "DSA123", 4, "Octavia", 50000 },
                    { 5, "Grey", 110, "DSA213", 5, "Corolla", 20000 },
                    { 6, "Dark Blue", 170, "SAA601", 6, "9-3", 5000 },
                    { 7, "Green", 80, "GFT154", 7, "Polo", 15000 },
                    { 8, "White", 140, "JPN001", 8, "i30", 75000 },
                    { 9, "Beige", 140, "RUS001", 9, "Granta", 4000 },
                    { 10, "Black", 661, "CSH247", 10, "Spider 488", 750000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "Red");

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "Yellow");

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "Yellow");
        }
    }
}
