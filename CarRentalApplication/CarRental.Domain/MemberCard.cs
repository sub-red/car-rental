using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class MemberCard
    {
        public int Id { get; set; }
        public int QrCode { get; set; }
        public IList<MemberDetails> Members { get; set; }
    }
}
