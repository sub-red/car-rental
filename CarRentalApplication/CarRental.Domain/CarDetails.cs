using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Domain
{
    public class CarDetails
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int ManufacturerId { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public CarManufacturer CarManufacturer { get; set; }
        public ICollection<CarCopy> Copies { get; set; }
        public RentalStatus RentalStatus
        {
            get
            {
                if (Rentals.Any(x => x.Returned == null))
                { return RentalStatus.Unavailable; }
                return RentalStatus.Available;
            }
        }

        

        public IList<Rentals> Rentals { get; set; }

    }
}
