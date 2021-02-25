using System.Collections.Generic;

namespace CleanCode.AgilePractices.BadSmells._12Loops
{
    public class CustomerService
    {
        public List<string> GetCustomer(List<Customer> customers)
        {
            return null;
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public string Job { get; set; }
    }
}