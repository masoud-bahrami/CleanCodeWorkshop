using System;

namespace CleanCode.AgilePractices.Smells
{
    public  class MyOrder
    {
        public decimal PriceOrder(Product product, int quntity, ShippingMethod shippingMethod)

        {
            var basePrice = product.BasePrice* quntity;
            decimal discount =Math.Max(quntity - product.DiscountThreshold, 0) * product.BasePrice * product.DiscountRate;
            decimal shippingPerCase = (basePrice > shippingMethod.DiscountThreshold)
                ? shippingMethod.DiscountFee
                : shippingMethod.FeePerCase;
            
            decimal shippingCost = quntity * shippingPerCase;
            decimal price = basePrice - discount + shippingCost;
            return price; 
        }
    }

    public class ShippingMethod
    {
        public decimal DiscountThreshold { get; set; }
        public decimal DiscountFee { get; set; }
        public decimal FeePerCase { get; set; }
    }

    public class Product
    {
        public decimal BasePrice { get; set; }
        public int DiscountThreshold { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
