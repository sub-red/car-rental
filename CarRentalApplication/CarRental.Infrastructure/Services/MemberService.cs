using CarRental.Application.Interfaces;
using CarRental.Domain;
using CarRental.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Infrastructure.Services
{
    public class MemberService : IMemberService
    {
        private readonly ApplicationDbContext context;

        public MemberService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddMember(MemberDetails member)
        {
            context.Add(member);
            context.SaveChanges();
        }

        public ICollection<MemberDetails> GetAllMembers()
        {
            return context.MemberDetails
                .Include(x => x.MemberCard)
                .OrderBy(x => x.MemberCard.MemberStatus).ToList();
        }

        public void UpdateMemberDetails(MemberDetails member)
        {
            context.Update(member);
            context.SaveChanges();
        }

        public void DeleteMember(MemberDetails member)
        {
            context.Remove(member);
            context.SaveChanges();
        }

        public ICollection<MemberDetails> ShowMemberDetails(int id)
        {
            var members = context.MemberDetails.Where(x => x.Id == id)
                   .ToList();
            var loans = context.Rentals.Where(x => x.MemberReferenceId == id).ToList();

            return members;
        }
    }
}
