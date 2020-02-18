using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class Rentals
    {
        public int Id { get; set; }
        public DateTime Rented { get; set; }
        public DateTime Returned { get; set; }
        public CarDetails CarReference { get; set; }
        public MemberDetails MemberReference { get; set; }
        public RentalLoan RentalLoan { get; set; }
        public int RentalLoanId { get; set; }
    }
}
