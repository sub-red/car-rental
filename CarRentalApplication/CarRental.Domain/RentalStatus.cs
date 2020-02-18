using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class RentalStatus
    {
        public int Id { get; set; }
        public string RentalLoanStatus { get; set; }
        public IList<CarDetails> Cars { get; set; }
    }
}
