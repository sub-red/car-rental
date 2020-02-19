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
    public class RentalLoanService : IRentalLoanService
    {
        private readonly ApplicationDbContext context;

        public RentalLoanService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IList<RentalLoan> GetAllRentalLoans()
        {
            return context.RentalLoans.OrderBy(x => x.RentalStatus).ToList();
        }


    }
}
