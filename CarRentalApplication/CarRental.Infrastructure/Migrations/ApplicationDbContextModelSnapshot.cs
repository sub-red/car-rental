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

                    b.Property<int?>("CarManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarManufacturerId");

                    b.ToTable("CarDetails");
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
                        .HasForeignKey("CarManufacturerId");
                });
#pragma warning restore 612, 618
        }
    }
}
