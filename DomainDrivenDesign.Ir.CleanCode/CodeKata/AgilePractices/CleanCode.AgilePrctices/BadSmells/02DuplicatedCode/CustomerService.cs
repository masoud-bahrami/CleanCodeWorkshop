using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.AgilePractices.BadSmells._02DuplicatedCode
{
    public class CustomerService
    {
        private readonly IList<Customer> _customers;

        public CustomerService(IList<Customer> customers)
        {
            _customers = customers;
        }

        public Customer GetCustomer(int id)
        {
            var queryable = _customers.Where(c => c.TenantId == UserContext.TenantId).AsQueryable();
            return queryable.FirstOrDefault(c => c.Id == id);
        }

        public Customer GetCustomerByNationalCode(string nationalCode)
        {
            return Queryable().FirstOrDefault(c => c.NationalCode == nationalCode);
        }

        public Customer GetAllCustomers()
        {
            return Queryable().FirstOrDefault();
        }

        private IQueryable<Customer> Queryable()
        {
            return _customers.Where(c => c.TenantId == UserContext.TenantId).AsQueryable();
        }
        
    }

    public class UserContext
    {
        public static Guid TenantId { get; set; }
    }

    public class Customer
    {
        public Guid TenantId { get; set; }
        public int Id { get; set; }
        public string NationalCode { get; set; }
    }
}
