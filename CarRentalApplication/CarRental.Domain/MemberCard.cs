using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain
{
    public class MemberCard
    {
        public int Id { get; set; }
        public string MemberStatus { get; set; }
        public IList<MemberDetails> Members { get; set; }
    }
}
