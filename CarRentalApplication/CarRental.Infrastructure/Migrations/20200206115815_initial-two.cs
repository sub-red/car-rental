using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDetails_CarManufacturers_CarManufacturerId",
                table: "CarDetails");

            migrationBuilder.DropIndex(
                name: "IX_CarDetails_CarManufacturerId",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "CarManufacturerId",
                table: "CarDetails");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "CarDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "CarManufacturers",
                columns: new[] { "Id", "Manufacturer" },
                values: new object[] { 1, "Hassan AB" });

            migrationBuilder.InsertData(
                table: "CarManufacturers",
                columns: new[] { "Id", "Manufacturer" },
                values: new object[] { 2, "Volvo" });

            migrationBuilder.InsertData(
                table: "CarManufacturers",
                columns: new[] { "Id", "Manufacturer" },
                values: new object[] { 3, "BMW" });

            migrationBuilder.InsertData(
                table: "CarDetails",
                columns: new[] { "Id", "Color", "HorsePower", "LicensePlate", "ManufacturerId", "Model", "Price" },
                values: new object[] { 1, "Red", 1337, "asd123", 1, "BMW", 500000 });

            migrationBuilder.InsertData(
                table: "CarDetails",
                columns: new[] { "Id", "Color", "HorsePower", "LicensePlate", "ManufacturerId", "Model", "Price" },
                values: new object[] { 2, "Yellow", 1337, "asd123", 2, "Vovlo", 400000 });

            migrationBuilder.InsertData(
                table: "CarDetails",
                columns: new[] { "Id", "Color", "HorsePower", "LicensePlate", "ManufacturerId", "Model", "Price" },
                values: new object[] { 3, "Yellow", 1337, "asd123", 3, "Vovlo", 400000 });

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_ManufacturerId",
                table: "CarDetails",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetails_CarManufacturers_ManufacturerId",
                table: "CarDetails",
                column: "ManufacturerId",
                principalTable: "CarManufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDetails_CarManufacturers_ManufacturerId",
                table: "CarDetails");

            migrationBuilder.DropIndex(
                name: "IX_CarDetails_ManufacturerId",
                table: "CarDetails");

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarManufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "CarDetails");

            migrationBuilder.AddColumn<int>(
                name: "CarManufacturerId",
                table: "CarDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarManufacturerId",
                table: "CarDetails",
                column: "CarManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetails_CarManufacturers_CarManufacturerId",
                table: "CarDetails",
                column: "CarManufacturerId",
                principalTable: "CarManufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
