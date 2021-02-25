using System;
using System.Collections.Generic;

namespace CleanCode.AgilePractices.BadSmells._01MysteriousNames
{
    public class Calendar
    {
        public void Subscribe(Customer customer)
        {

        }
    }

    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Role> Roles { get; set; }
        public  string UserName { get; set; }
        private string HashedPassword { get; set; }
    }

    public class Role
    {
    }
}