using CarRental.Application.Interfaces;
using CarRental.Domain;
using CarRental.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Infrastructure.Services
{
    public class MemberCardService : IMemberCardService
    {
        private readonly ApplicationDbContext context;

        public MemberCardService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IList<MemberCard> GetAllMemberCards()
        {
            return context.MemberCard.OrderBy(x => x.QrCode).ToList();
        }
    }
}
