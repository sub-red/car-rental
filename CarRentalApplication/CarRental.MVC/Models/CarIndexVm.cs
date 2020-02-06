﻿using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class CarIndexVm
    {
        public ICollection<CarDetails> Cars { get; set; } = new List<CarDetails>();
    }
}
