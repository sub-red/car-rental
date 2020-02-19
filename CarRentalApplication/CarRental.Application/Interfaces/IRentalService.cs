using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Interfaces
{
    public interface IRentalService
    {
        /// <summary>
        /// Gets all rentals from the database
        /// </summary>
        /// <returns>list of rentals</returns>
        //ICollection<Rentals> GetAllRentals();
        /// <summary>
        /// Adds the car to DB
        /// </summary>
        /// <param name="rental"></param>
        void AddRental(Rentals rental);

        ICollection<Rentals> GetAllAvailableCars();

        ICollection<Rentals> ShowRentalDetails(int id);
    }
}
