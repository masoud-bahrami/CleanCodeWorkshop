using System;

namespace CleanCode.AgilePractices.BadSmells._04LongParameter
{
    public class Customer
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public int BaseRate()
        {
            //TODO
            return 10 * Quantity;
        }
    }
    public class Class1
    {
        public void Calculate(Customer customer, bool includeTax)
        {
            var baseCharge = customer.BaseRate();

            if (includeTax)
            {
                var tax = Math.Max(0, baseCharge - TaxThreshold(customer.Year));
                //Apply tax
            }
        }

        private int TaxThreshold(int year)
        {
            return 10;
        }



    }
}