using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarManufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarManufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    HorsePower = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    CarManufacturerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarManufacturers_CarManufacturerId",
                        column: x => x.CarManufacturerId,
                        principalTable: "CarManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarCopy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCopy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarCopy_CarDetails_DetailsId",
                        column: x => x.DetailsId,
                        principalTable: "CarDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCopy_DetailsId",
                table: "CarCopy",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarManufacturerId",
                table: "CarDetails",
                column: "CarManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCopy");

            migrationBuilder.DropTable(
                name: "CarDetails");

            migrationBuilder.DropTable(
                name: "CarManufacturers");
        }
    }
}
