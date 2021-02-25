using System;

namespace CleanCode.AgilePractices.BadSmells._08FeatureEnvy
{
    public class Phone
    {
        private readonly string _unformattedNumber;
        public Phone(string unformattedNumber)
        {
            this._unformattedNumber = unformattedNumber;
        }
        public string GetAreaCode()
        {
            return _unformattedNumber.Substring(0, 3);
        }
        public string GetPrefix()
        {
            return _unformattedNumber.Substring(3, 6);
        }
        public string GetNumber()
        {
            return _unformattedNumber.Substring(6, 10);
        }
    }

    public class Customer
    {
        private readonly Phone _mobilePhone;

        public Customer(Phone mobilePhone)
        {
            this._mobilePhone = mobilePhone;
        }

        public string GetMobilePhoneNumber()
        {
            return "(" +
                   _mobilePhone.GetAreaCode() + ") " +
                   _mobilePhone.GetPrefix() + "-" +
                   _mobilePhone.GetNumber();
        }
    }
}