using CarRental.Domain;
using CarRental.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Infrastructure.Services
{
    public class RentalLoanService
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
