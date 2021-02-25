namespace CleanCode.AgilePractices.BadSmells._14SpeculativeGenerality
{
    public class OrderService
    {
        public void CreateOrder(int orderId, int customerId)
        {
            Order order = RetrieveOrder(orderId);
            Customer customer = RetrieveCustomer(customerId);
            //...
        }

        private Customer RetrieveCustomer(int customerId)
        {
            return new Customer();
        }

        private Order RetrieveOrder(int orderId)
        {
            return new Order();
        }
    }

    public class Customer
    {
    }

    public class Order
    {
        public string CustomerId { get; set; }
    }
}