using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class RentalLoan
    {
        public int Id { get; set; }
        public string RentalStatus { get; set; }
        public IList<Rentals> Rentals { get; set; }
    }
}
