using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class CarManufacturer
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public IList<CarDetails> Cars { get; set; }
    }
}
