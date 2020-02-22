using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class Rentals
    {
        public int Id { get; set; }
        public DateTime Rented { get; set; }
        public DateTime? Returned { get; set; }
        public CarDetails CarReference { get; set; }
        public MemberDetails MemberReference { get; set; }
        public int CarReferenceId { get; set; }
        public int MemberReferenceId { get; set; }
        public DateTime ExpectedReturn { get; set; }
        public int DaysRented
        {
            get
            {
                var timestamp = DateTime.Now - Rented;
                if (Returned.HasValue)
                {
                    timestamp = Returned.Value - Rented;
                }

                var days = (int)Math.Ceiling(timestamp.TotalDays);
                return days;
            }
        }
    }
}
