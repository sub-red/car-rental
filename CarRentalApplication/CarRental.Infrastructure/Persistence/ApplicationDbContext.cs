﻿using CarRental.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CarDetails> CarDetails { get; set; }
        public DbSet<CarManufacturer> CarManufacturers { get; set; }
        public DbSet<MemberDetails> MemberDetails { get; set; }
        public DbSet<MemberCard> MemberCard { get; set; }
        public DbSet<Rentals> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCarManufacturer(modelBuilder);
            ConfigureCarDetails(modelBuilder);
            ConfigureRentalStatus(modelBuilder);

            ConfigureMemberCard(modelBuilder);
            ConfigureMemberDetails(modelBuilder);

            ConfigureRentals(modelBuilder);
            SeedDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private static void SeedDatabase(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CarManufacturer>().HasData(
                new CarManufacturer { Id = 1, Manufacturer = "Volvo" },
                new CarManufacturer { Id = 2, Manufacturer = "Audi" },
                new CarManufacturer { Id = 3, Manufacturer = "BMW" },
                new CarManufacturer { Id = 4, Manufacturer = "Skoda" },
                new CarManufacturer { Id = 5, Manufacturer = "Toyota" },
                new CarManufacturer { Id = 6, Manufacturer = "Saab" },
                new CarManufacturer { Id = 7, Manufacturer = "Volkswagen" },
                new CarManufacturer { Id = 8, Manufacturer = "Hyundai" },
                new CarManufacturer { Id = 9, Manufacturer = "Lada" },
                new CarManufacturer { Id = 10, Manufacturer = "Ferrari" }
                );

            modelBuilder.Entity<CarDetails>().HasData(
                new CarDetails
                {
                    Id = 1,
                    ManufacturerId = 1,
                    Color = "Black",
                    Model = "V90",
                    HorsePower = 140,
                    LicensePlate = "ASD123",
                    Price = 500000
                },
                new CarDetails
                {
                    Id = 2,
                    ManufacturerId = 2,
                    Color = "Silver",
                    Model = "A3",
                    HorsePower = 200,
                    LicensePlate = "SAD123",
                    Price = 400000
                },
                new CarDetails
                {
                    Id = 3,
                    ManufacturerId = 3,
                    Color = "Black",
                    Model = "M5",
                    HorsePower = 240,
                    LicensePlate = "BLA773",
                    Price = 400000
                },
                new CarDetails
                {
                    Id = 4,
                    ManufacturerId = 4,
                    Color = "Blue",
                    Model = "Octavia",
                    HorsePower = 100,
                    LicensePlate = "DSA123",
                    Price = 50000
                },
                new CarDetails
                {
                    Id = 5,
                    ManufacturerId = 5,
                    Color = "Grey",
                    Model = "Corolla",
                    HorsePower = 110,
                    LicensePlate = "DSA213",
                    Price = 20000
                },
                new CarDetails
                {
                    Id = 6,
                    ManufacturerId = 6,
                    Color = "Dark Blue",
                    Model = "9-3",
                    HorsePower = 170,
                    LicensePlate = "SAA601",
                    Price = 5000
                },
                new CarDetails
                {
                    Id = 7,
                    ManufacturerId = 7,
                    Color = "Green",
                    Model = "Polo",
                    HorsePower = 80,
                    LicensePlate = "GFT154",
                    Price = 15000
                },
                new CarDetails
                {
                    Id = 8,
                    ManufacturerId = 8,
                    Color = "White",
                    Model = "i30",
                    HorsePower = 140,
                    LicensePlate = "JPN001",
                    Price = 75000
                },
                new CarDetails
                {
                    Id = 9,
                    ManufacturerId = 9,
                    Color = "Beige",
                    Model = "Granta",
                    HorsePower = 140,
                    LicensePlate = "RUS001",
                    Price = 4000
                },
                new CarDetails
                {
                    Id = 10,
                    ManufacturerId = 10,
                    Color = "Black",
                    Model = "Spider 488",
                    HorsePower = 661,
                    LicensePlate = "CSH247",
                    Price = 750000
                }
                );

            modelBuilder.Entity<MemberCard>().HasData(
                new MemberCard { Id = 1, MemberStatus = "Active" },
                new MemberCard { Id = 2, MemberStatus = "Inactive" },
                new MemberCard { Id = 3, MemberStatus = "Suspended, pending investigation" },
                new MemberCard { Id = 4, MemberStatus = "Permanently banned" }

                );

            modelBuilder.Entity<MemberDetails>().HasData(
                new MemberDetails
                {
                    Id = 1,
                    MemberCardId = 1,
                    FirstName = "Sven",
                    LastName = "Svensson",
                    Age = 75,
                    Adress = "Drottninggatan 1",
                    DriversLicense = 1111
                },
                new MemberDetails
                {
                    Id = 2,
                    MemberCardId = 2,
                    FirstName = "Karl",
                    LastName = "Karlsson",
                    Age = 65,
                    Adress = "Kungsgatan 1",
                    DriversLicense = 1112
                },
                new MemberDetails
                {
                    Id = 3,
                    MemberCardId = 3,
                    FirstName = "Johan",
                    LastName = "Johansson",
                    Age = 55,
                    Adress = "Prinsgatan 1",
                    DriversLicense = 2211
                },
                new MemberDetails
                {
                    Id = 4,
                    MemberCardId = 4,
                    FirstName = "Anders",
                    LastName = "Andersson",
                    Age = 12,
                    Adress = "Prinsessgatan 1",
                    DriversLicense = 2212
                }
                );

            //modelBuilder.Entity<Rentals>().HasData(
            //        new Rentals
            //        {
            //            Id = 1,
            //            Rented = DateTime.Now,
            //            Returned = null,

            //        }
            //        );


            /*
            modelBuilder.Entity<Rentals>().HasData(
                new Rentals { Id = 1, Rented = DateTime.Now}

                );
                */
        }

        private static void ConfigureCarManufacturer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarManufacturer>().Property(x => x.Manufacturer).HasMaxLength(55);
        }

        private static void ConfigureCarDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDetails>().HasKey(x => x.Id);
            modelBuilder.Entity<CarDetails>()
                .HasOne(b => b.CarManufacturer)
                .WithMany(a => a.Cars)
                .HasForeignKey(b => b.ManufacturerId);
        }

        private static void ConfigureMemberCard(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberCard>().Property(x => x.MemberStatus).HasMaxLength(55);
        }

        private static void ConfigureMemberDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberDetails>().HasKey(x => x.Id);
            modelBuilder.Entity<MemberDetails>()
                .HasOne(b => b.MemberCard)
                .WithMany(a => a.Members)
                .HasForeignKey(b => b.MemberCardId);
        }

        private static void ConfigureRentalStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDetails>().HasKey(x => x.Id);
        }

        private static void ConfigureRentals(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rentals>().HasKey(x => x.Id);
            modelBuilder.Entity<Rentals>()
                .HasOne(b => b.CarReference)
                .WithMany(a => a.Rentals)
                .HasForeignKey(b => b.CarReferenceId);
        }
    }
}
