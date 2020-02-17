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
    public class RentalService : IRentalService
    {
        private readonly ApplicationDbContext context;

        public RentalService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddRental(Rentals rental)
        {
            context.Add(rental);
            context.SaveChanges();
        }

        public ICollection<Rentals> GetAllRentals()
        {
            return context.Rentals.Include(x => x.RentalLoan).OrderBy(x => x.RentalLoan.RentalStatus).ToList();
        }


        public ICollection<Rentals> ShowRentalDetails(int id)
        {
            return context.Rentals.Where(x => x.Id == id).ToList();
        }
    }
}
