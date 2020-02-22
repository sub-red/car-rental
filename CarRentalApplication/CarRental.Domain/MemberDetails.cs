using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class MemberDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public int DriversLicense { get; set; }
        public int MemberCardId { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public MemberCard MemberCard { get; set; }
        public IList<Rentals> Rentals { get; set; }
    }
}
