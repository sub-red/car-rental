using CarRental.Application.Interfaces;
using CarRental.Domain;
using CarRental.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Infrastructure.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext context;

        public CarService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddCar(CarDetails car)
        {
            context.Add(car);
            context.SaveChanges();
        }

        public ICollection<CarDetails> GetAllCars() 
        {
            return context.CarDetails.Include(x => x.CarManufacturer).OrderBy(x => x.Model).ToList();
        }

        public void UpdateCarDetails(CarDetails car)
        {
            throw new NotImplementedException();
        }

        public void UpdateCarDetails(int id, CarDetails car)
        {
            throw new NotImplementedException();
        }
    }
}
