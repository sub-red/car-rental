using CarRental.Domain;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCarManufacturer(modelBuilder);
            ConfigureCarDetails(modelBuilder);

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
    }
}
