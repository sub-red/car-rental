using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class MemberCreateVm
    {
        public MemberCreateVm()
        {
            MemberCardId = 1;
        }
        /*
        [Display(Name = "Member-Status")]
        public SelectList MemberStatusList { get; set; }    
        */
        [Display(Name = "First name")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Adress")]
        [MaxLength(10)]
        public string Adress { get; set; }

        [Display(Name = "Drivers license 4d")]
        public int DriversLicense { get; set; }

        [Required]
        public int MemberCardId { get; set; }
    }
}
