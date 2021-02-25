using System;

namespace CleanCode.AgilePractices.SOLID.OCP.OrderDiscount
{
    public class Order
    {
        public decimal TotalPrice { get; set; }
        public void ApplyDiscount(Discount discount)
        {
            TotalPrice = discount.Apply(TotalPrice);
        }
    }

    public enum DiscountCodeExpirationType
    {
        BaseOnNumberOfUsage,
        BaseOnExpirationDate
    }

    public enum DiscountType
    {
        FixedAmount,
        Precentage
    }

    public class DiscountCodeExpiredException : Exception
    {
        public readonly string DiscountCode;

        public DiscountCodeExpiredException(string discountCode)
        {
            DiscountCode = discountCode;
        }
    }

    public class FixedDiscountCode : Discount
    {
        protected override decimal ApplyDiscount(decimal price)
        {
            return price - Amount;
        }

    }

    public class PrecentageDiscountCode : Discount
    {
        protected override decimal ApplyDiscount(decimal price)
        {
            return price - ((price * Amount) / 100);
        }
    }

    public class DiscountExpirationPolicy
    {
        public DiscountCodeExpirationType ExpirationType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int AllowedNumberOfUsage { get; set; }
        public void Guard(string code, int numberOfUsed)
        {
            if (ExpirationType == DiscountCodeExpirationType.BaseOnNumberOfUsage && numberOfUsed >= AllowedNumberOfUsage)
                throw new DiscountCodeExpiredException(code);

            if (ExpirationType == DiscountCodeExpirationType.BaseOnExpirationDate && DateTime.Now > ExpirationDate)
                throw new DiscountCodeExpiredException(code);
        }

    }
    public abstract class Discount
    {
        public decimal Amount { get; private set; }
        //public bool IsUsed { get; set; }
        public string Code { get; set; }
        public DiscountType Type { get; set; }
        public int NumberOfUsed { get; set; }
        public DiscountExpirationPolicy AllowedNumberOfUsage { get; set; }

        public virtual decimal Apply(decimal price)
        {
            Guard();
            var result = ApplyDiscount(price);
            NumberOfUsed++;
            return result;
        }

        protected abstract decimal ApplyDiscount(decimal price);

        private void Guard()
        {
            AllowedNumberOfUsage.Guard(Code, NumberOfUsed);
        }
    }
}