using k_k.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace k_k.EF
{
    public class userMethods
    {
        private KuKContext _context = new KuKContext { };
        public bool AddUser(string firstName, string lastName, string passwordHash, string emailAddress, string phoneNumber)
        {
            bool result = false; //is false but it is clearer this way
            var user = new kukUser
            {
                FirstName = firstName,
                LastName = lastName,
                PasswordHash = passwordHash,
                UserName =emailAddress,
                Email = emailAddress,
                EmailConfirmed = false,
                PhoneNumber = phoneNumber
            };
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                result = true;
            }
            catch (Exception ex) //antipatern but catch any exception an log it later, every exception shuld be threated other but we expect only db excepions since we have a litle logic 
            {
                throw ex; //thow old exception to not lose stacktrace
            }
            return result;
        }
    }
}
