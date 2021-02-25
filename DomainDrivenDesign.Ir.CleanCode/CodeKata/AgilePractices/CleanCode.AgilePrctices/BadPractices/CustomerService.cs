using System;
using System.Threading.Tasks;

namespace CleanCode.AgilePractices.BadPractices
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task CreateCustomer(CustomerDto dto)
        {
            await GuardAgainstDuplicateCustomer(dto.NationalCode);
            
            var newCustomer = new Customer
            {
                NationalCode = dto.NationalCode,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };

            await _customerRepository.Create(newCustomer);
        }

        private async Task GuardAgainstDuplicateCustomer(string nationalCode)
        {
            bool isExists = await _customerRepository.ExistCustomerWithId(nationalCode);

            if (isExists)
                throw new ExistCustomerException(nationalCode);
        }

        public async Task UpdateCustomer(CustomerDto dto)
        {
            Customer person = await _customerRepository.GetCustomer(dto);

            if (person == null)
                throw new NotExistsCustomerException();

            person.NationalCode = dto.NationalCode;
            person.FirstName = dto.FirstName;
            person.LastName = dto.LastName;

            await _customerRepository.Update(person);
        }
    }

    public class NotExistsCustomerException : Exception
    {
    }

      public class ExistCustomerException : Exception
    {
        public string NationalCode;

        public ExistCustomerException(string nationalCode)
        {
            NationalCode = nationalCode;
        }
    }

    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(CustomerDto dto);
        Task Create(Customer customer);
        Task Update(Customer person);
        Task<bool> ExistCustomerWithId(string nationalCode);
    }

  
    public class Customer
    {
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class CustomerDto
    {
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}