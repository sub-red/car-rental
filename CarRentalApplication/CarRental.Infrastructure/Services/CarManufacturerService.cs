using CarRental.Application.Interfaces;
using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Services
{
    public class CarManufacturerService : ICarManufacturerService
    {
        private readonly ApplicationDbContext context;

        public CarManufacturerService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IList<CarManufacturer> GetAllCarManufacturers()
        {
            return context.CarManufacturers.OrderBy(x => x.Manufacturer).ToList();
        }
    }
}
