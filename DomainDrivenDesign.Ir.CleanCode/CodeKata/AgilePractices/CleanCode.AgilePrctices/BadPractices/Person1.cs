namespace CleanCode.AgilePractices.BadPractices
{
    public class Address
    {
        public string City;
        public string Country;
        public string Province;
    }

    public class Person1
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private Address _address;

        public Person1(string firstName, string lastName, Address address)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }
    }
}
