using System;

namespace CleanCode.AgilePractices.BadSmells._13LazyElement
{
    public class OrderService
    {
        public void Cancel(Order anOrder)
        {
            var orderStatus = GetOrderStatus(anOrder);
            
            if (orderStatus == OrderStatus.Shipped)
                throw new Exception("the order already shipped!");
        }

        private OrderStatus GetOrderStatus(Order anOrder)
        {
            return anOrder.GetStatus();
        }
    }

    public class Order
    {
        private readonly OrderStatus _status;

        public Order(OrderStatus status)
        {
            _status = status;
        }

        public OrderStatus GetStatus()
        {
            return _status;
        }
    }

    public enum OrderStatus
    {
        Shipped
    }
}
