using System;

namespace CleanCode.AgilePractices.BadPractices
{
    public class Person
    {
        //Magic numbers
        const int MinumumAge = 0;
        const int MaxAge = 120;

        private int age;
        private string _address;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person(int age, string address)
        {
            if (!ValidateAge(age))
                throw new Exception();

            this.age = age;
            this._address = address;

        }
        
        private bool ValidateAge(int age)
        {
            return MinumumAge > 0 & age < MaxAge;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string ReturnFulName()
        {
            return FirstName + " " + LastName + " " + age + "ساله" + "از " + _address;
        }
    }
}
