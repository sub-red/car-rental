using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Interfaces
{
    public interface IMemberService
    {
        /// <summary>
        /// Adds the member to DB
        /// </summary>
        /// <param name="member"></param>
        void AddMember(MemberDetails member);

        /// <summary>
        /// Updates a member
        /// </summary>
        /// <param name="member"></param>
        void UpdateMemberDetails(MemberDetails member);

        /// <summary>
        /// Gets all members from the database
        /// </summary>
        /// <returns>list of members</returns>
        ICollection<MemberDetails> GetAllMembers();

        /// <summary>
        /// Deletes the selected members from db
        /// </summary>
        /// <param name="member"></param>
        void DeleteMember(MemberDetails member);

        ICollection<MemberDetails> ShowMemberDetails(int id);
    }
}
