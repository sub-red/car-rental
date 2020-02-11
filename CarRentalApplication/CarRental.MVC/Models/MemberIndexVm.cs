using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models
{
    public class MemberIndexVm
    {
        public ICollection<MemberDetails> Members { get; set; } = new List<MemberDetails>();
    }
}
