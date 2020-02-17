using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class RentalIndexVm
    {
        public ICollection<Rentals> Rentals { get; set; } = new List<Rentals>();
    }
}
