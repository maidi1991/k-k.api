using k_k.EF;
using System;

namespace k_k.Service
{
    public class UserService
    {
        private userMethods _methods = new userMethods();
        public bool AddUser(string firstName, string lastName, string passwordHash, string emailAddress, string phoneNumber)
        {
            bool result = false; //see comment in method
            try
            {
                _methods.AddUser(firstName, lastName, passwordHash, emailAddress, phoneNumber);
                result = true;
            }
            catch(Exception ex)//see comment in method
            {
                throw ex;
            }
            return result;
        }
    }
}
