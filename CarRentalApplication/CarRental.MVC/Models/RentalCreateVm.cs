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
            ExpectedReturn = DateTime.Now.AddDays(14);
        }

        [Display(Name = "Rented")]
        public DateTime Rented { get; set; }

        [Display(Name = "Expected return")]
        public DateTime ExpectedReturn { get; set; }

        [Display(Name = "RentalCar")]
        public SelectList CarList { get; set; }

        [Display(Name = "RentalMember")]
        public SelectList MembersList { get; set; }
        [Required]
        public int CarReferenceId { get; set; }

        [Required]
        public int MemberCardId { get; set; }
        
        public int RentalLoanId { get; set; }

    }
}
