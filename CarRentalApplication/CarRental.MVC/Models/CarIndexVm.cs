using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class CarIndexVm
    {
        public IList<RentalStatus> RentalStatus { get; set; }
        enum InternetStatus
        {
            Online,
            Offline,
            Away
        }
        public ICollection<CarDetails> Cars { get; set; } = new List<CarDetails>();
    }
}
