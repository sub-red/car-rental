﻿// <auto-generated />
using System;
using CarRental.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRental.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRental.Domain.CarCopy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DetailsId");

                    b.ToTable("CarCopy");
                });

            modelBuilder.Entity("CarRental.Domain.CarDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("CarDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Black",
                            HorsePower = 140,
                            LicensePlate = "ASD123",
                            ManufacturerId = 1,
                            Model = "V90",
                            Price = 500000
                        },
                        new
                        {
                            Id = 2,
                            Color = "Silver",
                            HorsePower = 200,
                            LicensePlate = "SAD123",
                            ManufacturerId = 2,
                            Model = "A3",
                            Price = 400000
                        },
                        new
                        {
                            Id = 3,
                            Color = "Black",
                            HorsePower = 240,
                            LicensePlate = "BLA773",
                            ManufacturerId = 3,
                            Model = "M5",
                            Price = 400000
                        },
                        new
                        {
                            Id = 4,
                            Color = "Blue",
                            HorsePower = 100,
                            LicensePlate = "DSA123",
                            ManufacturerId = 4,
                            Model = "Octavia",
                            Price = 50000
                        },
                        new
                        {
                            Id = 5,
                            Color = "Grey",
                            HorsePower = 110,
                            LicensePlate = "DSA213",
                            ManufacturerId = 5,
                            Model = "Corolla",
                            Price = 20000
                        },
                        new
                        {
                            Id = 6,
                            Color = "Dark Blue",
                            HorsePower = 170,
                            LicensePlate = "SAA601",
                            ManufacturerId = 6,
                            Model = "9-3",
                            Price = 5000
                        },
                        new
                        {
                            Id = 7,
                            Color = "Green",
                            HorsePower = 80,
                            LicensePlate = "GFT154",
                            ManufacturerId = 7,
                            Model = "Polo",
                            Price = 15000
                        },
                        new
                        {
                            Id = 8,
                            Color = "White",
                            HorsePower = 140,
                            LicensePlate = "JPN001",
                            ManufacturerId = 8,
                            Model = "i30",
                            Price = 75000
                        },
                        new
                        {
                            Id = 9,
                            Color = "Beige",
                            HorsePower = 140,
                            LicensePlate = "RUS001",
                            ManufacturerId = 9,
                            Model = "Granta",
                            Price = 4000
                        },
                        new
                        {
                            Id = 10,
                            Color = "Black",
                            HorsePower = 661,
                            LicensePlate = "CSH247",
                            ManufacturerId = 10,
                            Model = "Spider 488",
                            Price = 750000
                        });
                });

            modelBuilder.Entity("CarRental.Domain.CarManufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("CarManufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Manufacturer = "Volvo"
                        },
                        new
                        {
                            Id = 2,
                            Manufacturer = "Audi"
                        },
                        new
                        {
                            Id = 3,
                            Manufacturer = "BMW"
                        },
                        new
                        {
                            Id = 4,
                            Manufacturer = "Skoda"
                        },
                        new
                        {
                            Id = 5,
                            Manufacturer = "Toyota"
                        },
                        new
                        {
                            Id = 6,
                            Manufacturer = "Saab"
                        },
                        new
                        {
                            Id = 7,
                            Manufacturer = "Volkswagen"
                        },
                        new
                        {
                            Id = 8,
                            Manufacturer = "Hyundai"
                        },
                        new
                        {
                            Id = 9,
                            Manufacturer = "Lada"
                        },
                        new
                        {
                            Id = 10,
                            Manufacturer = "Ferrari"
                        });
                });

            modelBuilder.Entity("CarRental.Domain.MemberCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MemberStatus")
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("MemberCard");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MemberStatus = "Active"
                        },
                        new
                        {
                            Id = 2,
                            MemberStatus = "Inactive"
                        },
                        new
                        {
                            Id = 3,
                            MemberStatus = "Suspended, pending investigation"
                        },
                        new
                        {
                            Id = 4,
                            MemberStatus = "Permanently banned"
                        });
                });

            modelBuilder.Entity("CarRental.Domain.MemberDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DriversLicense")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberCardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberCardId");

                    b.ToTable("MemberDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Drottninggatan 1",
                            Age = 75,
                            DriversLicense = 1111,
                            FirstName = "Sven",
                            LastName = "Svensson",
                            MemberCardId = 1
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Kungsgatan 1",
                            Age = 65,
                            DriversLicense = 1112,
                            FirstName = "Karl",
                            LastName = "Karlsson",
                            MemberCardId = 2
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Prinsgatan 1",
                            Age = 55,
                            DriversLicense = 2211,
                            FirstName = "Johan",
                            LastName = "Johansson",
                            MemberCardId = 3
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Prinsessgatan 1",
                            Age = 12,
                            DriversLicense = 2212,
                            FirstName = "Anders",
                            LastName = "Andersson",
                            MemberCardId = 4
                        });
                });

            modelBuilder.Entity("CarRental.Domain.CarCopy", b =>
                {
                    b.HasOne("CarRental.Domain.CarDetails", "Details")
                        .WithMany("Copies")
                        .HasForeignKey("DetailsId");
                });

            modelBuilder.Entity("CarRental.Domain.CarDetails", b =>
                {
                    b.HasOne("CarRental.Domain.CarManufacturer", "CarManufacturer")
                        .WithMany("Cars")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental.Domain.MemberDetails", b =>
                {
                    b.HasOne("CarRental.Domain.MemberCard", "MemberCard")
                        .WithMany("Members")
                        .HasForeignKey("MemberCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
