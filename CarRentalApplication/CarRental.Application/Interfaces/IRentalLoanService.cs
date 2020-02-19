using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Interfaces
{
    public interface IRentalLoanService
    {
        IList<RentalLoan> GetAllRentalLoans();

    }
}
