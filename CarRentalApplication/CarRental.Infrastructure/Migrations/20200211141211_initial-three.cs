using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberStatus = table.Column<string>(maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    DriversLicense = table.Column<int>(nullable: false),
                    MemberCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberDetails_MemberCard_MemberCardId",
                        column: x => x.MemberCardId,
                        principalTable: "MemberCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "HorsePower", "LicensePlate", "Model" },
                values: new object[] { "Black", 140, "ASD123", "V90" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "HorsePower", "LicensePlate", "Model" },
                values: new object[] { "Silver", 200, "SAD123", "A3" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "HorsePower", "LicensePlate", "Model" },
                values: new object[] { "Black", 240, "BLA773", "M5" });

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
                table: "MemberCard",
                columns: new[] { "Id", "MemberStatus" },
                values: new object[,]
                {
                    { 1, "Active" },
                    { 2, "Inactive" }
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

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Adress", "Age", "DriversLicense", "FirstName", "LastName", "MemberCardId" },
                values: new object[,]
                {
                    { 1, "Drottninggatan 1", 75, 1111, "Sven", "Svensson", 1 },
                    { 2, "Kungsgatan 1", 65, 1112, "Karl", "Karlsson", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberDetails_MemberCardId",
                table: "MemberDetails",
                column: "MemberCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberDetails");

            migrationBuilder.DropTable(
                name: "MemberCard");

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
                columns: new[] { "Color", "HorsePower", "LicensePlate", "Model" },
                values: new object[] { "Red", 1337, "asd123", "BMW" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "HorsePower", "LicensePlate", "Model" },
                values: new object[] { "Yellow", 1337, "asd123", "Vovlo" });

            migrationBuilder.UpdateData(
                table: "CarDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "HorsePower", "LicensePlate", "Model" },
                values: new object[] { "Yellow", 1337, "asd123", "Vovlo" });

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
