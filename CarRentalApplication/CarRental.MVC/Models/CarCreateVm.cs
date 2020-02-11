using CarRental.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class CarCreateVm
    {

        [Display(Name = "Manufacturer")]
        public SelectList CarManufacturerList { get; set; }
        
        [Display(Name = "Model")]
        [MaxLength(30)]
        public string Model { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Horsepower")]
        public int HorsePower { get; set; }

        [Display(Name = "License plate")]
        [MaxLength(10)]
        public string LicensePlate { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        public int ManufacturerId { get; set; }
    }
}
