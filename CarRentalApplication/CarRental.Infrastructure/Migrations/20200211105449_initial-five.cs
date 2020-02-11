using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class initialfive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QrCode = table.Column<int>(maxLength: 55, nullable: false)
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

            migrationBuilder.InsertData(
                table: "MemberCard",
                columns: new[] { "Id", "QrCode" },
                values: new object[] { 1, 123 });

            migrationBuilder.InsertData(
                table: "MemberCard",
                columns: new[] { "Id", "QrCode" },
                values: new object[] { 2, 124 });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Adress", "Age", "DriversLicense", "FirstName", "LastName", "MemberCardId" },
                values: new object[] { 1, "Drottninggatan 1", 75, 1111, "Sven", "Svensson", 1 });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Adress", "Age", "DriversLicense", "FirstName", "LastName", "MemberCardId" },
                values: new object[] { 2, "Kungsgatan 1", 65, 1112, "Karl", "Karlsson", 2 });

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
        }
    }
}
