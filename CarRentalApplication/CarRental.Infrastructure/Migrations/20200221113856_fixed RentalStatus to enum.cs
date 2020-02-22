using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class fixedRentalStatustoenum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDetails_RentalStatus_RentalStatusId1",
                table: "CarDetails");

            migrationBuilder.DropTable(
                name: "RentalStatus");

            migrationBuilder.DropIndex(
                name: "IX_CarDetails_RentalStatusId1",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "RentalStatusId1",
                table: "CarDetails");

            migrationBuilder.AddColumn<int>(
                name: "RentalStatus",
                table: "CarDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentalStatus",
                table: "CarDetails");

            migrationBuilder.AddColumn<int>(
                name: "RentalStatusId1",
                table: "CarDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RentalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalLoanStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalStatus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RentalStatus",
                columns: new[] { "Id", "RentalLoanStatus" },
                values: new object[] { 1, "Available" });

            migrationBuilder.InsertData(
                table: "RentalStatus",
                columns: new[] { "Id", "RentalLoanStatus" },
                values: new object[] { 2, "Unavailable" });

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_RentalStatusId1",
                table: "CarDetails",
                column: "RentalStatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetails_RentalStatus_RentalStatusId1",
                table: "CarDetails",
                column: "RentalStatusId1",
                principalTable: "RentalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
