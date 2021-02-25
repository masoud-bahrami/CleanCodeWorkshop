namespace CleanCode.AgilePractices.BadSmells._02DuplicatedCode
{
    public class Class1
    {
        public void DoSomething()
        {
            PricingPlanUnit chargePerUnit = RetrievePricingPlanUnit();

            Order order = RetrieveOrder();
            decimal charge;
            //...
        }

        public void DoAnotherThing()
        {
            PricingPlanUnit chargePerUnit = RetrievePricingPlanUnit();
            
            var customer = RetrieveCustomer();

            double discountPercentage = 0;
            if (customer.IsVIP())
            {
                discountPercentage = 75;
            }
            if (discountPercentage == 100)
                return;

            Order order = RetrieveOrder();
            decimal charge;


            //...
        }

        private Order RetrieveOrder()
        {
            throw new System.NotImplementedException();
        }

        private MyCustomer RetrieveCustomer()
        {
            throw new System.NotImplementedException();
        }

        private PricingPlanUnit RetrievePricingPlanUnit()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Order
    {
    }

    public class PricingPlan
    {
        public PricingPlanUnit Unit { get; set; }
    }

    public class PricingPlanUnit
    {
    }

    public class MyCustomer
    {

        public bool IsVIP()
        {
            return true;
        }
    }
}