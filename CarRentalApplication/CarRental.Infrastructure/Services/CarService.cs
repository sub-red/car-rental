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
            return context.CarDetails
                .Include(x => x.CarManufacturer)
                .Include(x => x.RentalStatus)
                .OrderBy(x => x.CarManufacturer.Manufacturer).ToList();
        }

        public void UpdateCarDetails(CarDetails car)
        {
            context.Update(car);
            context.SaveChanges();
        }

        public void UpdateCarDetails(int id, CarDetails car)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(CarDetails car)
        {
            context.Remove(car);
            context.SaveChanges();
        }

        public ICollection<CarDetails> ShowCarDetails(int id)
        {
            return context.CarDetails.Where(x => x.Id == id).ToList();
        }

    }
}
