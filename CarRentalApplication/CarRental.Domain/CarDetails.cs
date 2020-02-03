using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class CarDetails
    {
        public int Id { get; set; }
        //public string ModelNumber { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }   
        public int HorsePower { get; set; }
        public int ManufacturerId { get; set; } 
        public int Price { get; set; }
        public string Color { get; set; }
        public CarManufacturer CarManufacturer { get; set; }
        public ICollection<CarCopy> Copies { get; set; }
    }
}
