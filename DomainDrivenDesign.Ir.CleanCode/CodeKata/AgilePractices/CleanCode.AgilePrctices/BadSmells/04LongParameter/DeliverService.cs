using System;
using System.Collections.Generic;

namespace CleanCode.AgilePractices.BadSmells._04LongParameter
{
    public class DeliverService
    {
        public DateTime DeliveryDate(Order order, bool isRush)
        {
            if (isRush)
            {
                var deliveryTime = RushDeliveryTime(order);
                return deliveryTime;
            }
            else
            {
                var deliveryTime1 = NormalDeliveryTime(order);
                return deliveryTime1;
            }

        }

        private static DateTime NormalDeliveryTime(Order order)
        {
            DateTime result;
            if (new List<string> { "XYZ", "ABC" }.Contains(order.DeliveryState))
                result = DateTime.Now.AddDays(5);
            else if (new List<string> { "AP", "DC" }.Contains(order.DeliveryState))
                result = DateTime.Now.AddDays(7);
            else result = DateTime.Now.AddDays(6);
            return result;
        }

        private static DateTime RushDeliveryTime(Order order)
        {
            DateTime result;
            if (new List<string> { "MA", "CT" }.Contains(order.DeliveryState))
                result = DateTime.Now.AddDays(1);
            else if (new List<string> { "NY", "NH" }.Contains(order.DeliveryState))
                result = DateTime.Now.AddDays(2);
            else result = DateTime.Now.AddDays(3);
            return result;
        }
    }

    public class Order
    {
        public string DeliveryState { get; set; }
    }
}