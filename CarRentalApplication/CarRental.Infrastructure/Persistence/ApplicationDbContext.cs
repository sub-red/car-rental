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
                new CarManufacturer { Id = 1, Manufacturer = "Hassan AB" },
                new CarManufacturer { Id = 2, Manufacturer = "Volvo" },
                new CarManufacturer { Id = 3, Manufacturer = "BMW" }
                );

            modelBuilder.Entity<CarDetails>().HasData(
                new CarDetails
                {
                    Id = 1,
                    ManufacturerId = 1,
                    Color = "Red",
                    Model = "BMW",
                    HorsePower = 1337,
                    LicensePlate = "asd123",
                    Price = 500000
                },
                new CarDetails
                {
                    Id = 2,
                    ManufacturerId = 2,
                    Color = "Yellow",
                    Model = "Vovlo",
                    HorsePower = 1337,
                    LicensePlate = "asd123",
                    Price = 400000
                },
                new CarDetails
                {
                    Id = 2,
                    ManufacturerId = 2,
                    Color = "Yellow",
                    Model = "Vovlo",
                    HorsePower = 1337,
                    LicensePlate = "asd123",
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
