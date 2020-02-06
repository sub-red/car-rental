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
                new CarManufacturer { Id = 3, Manufacturer = "BMW" }
                );

            modelBuilder.Entity<CarDetails>().HasData(
                new CarDetails
                {
                    Id = 1,
                    ManufacturerId = 1,
                    Color = "Red",
                    Model = "V90",
                    HorsePower = 140,
                    LicensePlate = "ASD123",
                    Price = 500000
                },
                new CarDetails
                {
                    Id = 2,
                    ManufacturerId = 2,
                    Color = "Yellow",
                    Model = "A3",
                    HorsePower = 200,
                    LicensePlate = "SAD123",
                    Price = 400000
                },
                new CarDetails
                {
                    Id = 3,
                    ManufacturerId = 3,
                    Color = "Yellow",
                    Model = "M5",
                    HorsePower = 240,
                    LicensePlate = "BLA773",
                    Price = 400000
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
