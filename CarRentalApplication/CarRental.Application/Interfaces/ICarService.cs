using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Interfaces
{
    public interface ICarService
    {
        /// <summary>
        /// Adds the car to DB
        /// </summary>
        /// <param name="car"></param>
        void AddCar(CarDetails car);

        /// <summary>
        /// Updates a car
        /// </summary>
        /// <param name="car"></param>
        void UpdateCarDetails(CarDetails car);

        /// <summary>
        /// Updates a car.
        /// </summary>
        /// <param name="id">Id of car to update</param>
        /// <param name="car">New values of car (Id is ignored)</param>
        void UpdateCarDetails(int id, CarDetails car);
        /// <summary>
        /// Gets all cars from the database
        /// </summary>
        /// <returns>list of cars</returns>
        ICollection<CarDetails> GetAllCars();

        /// <summary>
        /// Deletes the selected car from db
        /// </summary>
        /// <param name="car"></param>
        void DeleteCar(CarDetails car);
    }
}
