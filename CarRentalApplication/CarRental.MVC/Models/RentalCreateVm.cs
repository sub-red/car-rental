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
        public RentalCreateVm()
        {
            Rented = DateTime.Now;
            Returned = DateTime.Now;
        }

        [Display(Name = "Rented")]
        public DateTime Rented { get; set; }

        [Display(Name = "Returned")]
        public DateTime Returned { get; set; }

        [Display(Name = "RentalCar")]
        public SelectList CarList { get; set; }

        [Display(Name = "RentalMember")]
        public SelectList MembersList { get; set; }
        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        public int MemberCardId { get; set; }
        
        public int RentalLoanId { get; set; }

    }
}
