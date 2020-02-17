using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class RentalCreateVm
    {

        [Display(Name = "Rented")]
        public DateTime Rented { get; set; }

        [Display(Name = "Returned")]
        public DateTime Returned { get; set; }

        public SelectList CarManufacturerList { get; set; }
        public SelectList MembersList { get; set; }

    }
}
