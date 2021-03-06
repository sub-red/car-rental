﻿using System;
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
                name: "RentalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalLoanStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalStatus", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    HorsePower = table.Column<int>(nullable: false),
                    ManufacturerId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    RentalStatusId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarManufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "CarManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_RentalStatus_RentalStatusId1",
                        column: x => x.RentalStatusId1,
                        principalTable: "RentalStatus",
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

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rented = table.Column<DateTime>(nullable: false),
                    Returned = table.Column<DateTime>(nullable: true),
                    CarReferenceId = table.Column<int>(nullable: false),
                    MemberReferenceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_CarDetails_CarReferenceId",
                        column: x => x.CarReferenceId,
                        principalTable: "CarDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_MemberDetails_MemberReferenceId",
                        column: x => x.MemberReferenceId,
                        principalTable: "MemberDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarManufacturers",
                columns: new[] { "Id", "Manufacturer" },
                values: new object[,]
                {
                    { 1, "Volvo" },
                    { 2, "Audi" },
                    { 3, "BMW" },
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
                    { 2, "Inactive" },
                    { 3, "Suspended, pending investigation" },
                    { 4, "Permanently banned" }
                });

            migrationBuilder.InsertData(
                table: "RentalStatus",
                columns: new[] { "Id", "RentalLoanStatus" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Unavailable" }
                });

            migrationBuilder.InsertData(
                table: "CarDetails",
                columns: new[] { "Id", "Color", "HorsePower", "LicensePlate", "ManufacturerId", "Model", "Price", "RentalStatusId1" },
                values: new object[,]
                {
                    { 1, "Black", 140, "ASD123", 1, "V90", 500000, null },
                    { 2, "Silver", 200, "SAD123", 2, "A3", 400000, null },
                    { 3, "Black", 240, "BLA773", 3, "M5", 400000, null },
                    { 4, "Blue", 100, "DSA123", 4, "Octavia", 50000, null },
                    { 5, "Grey", 110, "DSA213", 5, "Corolla", 20000, null },
                    { 6, "Dark Blue", 170, "SAA601", 6, "9-3", 5000, null },
                    { 7, "Green", 80, "GFT154", 7, "Polo", 15000, null },
                    { 8, "White", 140, "JPN001", 8, "i30", 75000, null },
                    { 9, "Beige", 140, "RUS001", 9, "Granta", 4000, null },
                    { 10, "Black", 661, "CSH247", 10, "Spider 488", 750000, null }
                });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Adress", "Age", "DriversLicense", "FirstName", "LastName", "MemberCardId" },
                values: new object[,]
                {
                    { 1, "Drottninggatan 1", 75, 1111, "Sven", "Svensson", 1 },
                    { 2, "Kungsgatan 1", 65, 1112, "Karl", "Karlsson", 2 },
                    { 3, "Prinsgatan 1", 55, 2211, "Johan", "Johansson", 3 },
                    { 4, "Prinsessgatan 1", 12, 2212, "Anders", "Andersson", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCopy_DetailsId",
                table: "CarCopy",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_ManufacturerId",
                table: "CarDetails",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_RentalStatusId1",
                table: "CarDetails",
                column: "RentalStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_MemberDetails_MemberCardId",
                table: "MemberDetails",
                column: "MemberCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarReferenceId",
                table: "Rentals",
                column: "CarReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_MemberReferenceId",
                table: "Rentals",
                column: "MemberReferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCopy");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "CarDetails");

            migrationBuilder.DropTable(
                name: "MemberDetails");

            migrationBuilder.DropTable(
                name: "CarManufacturers");

            migrationBuilder.DropTable(
                name: "RentalStatus");

            migrationBuilder.DropTable(
                name: "MemberCard");
        }
    }
}
