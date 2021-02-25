namespace CleanCode.AgilePractices.BadSmells._05MutableData
{
    
    public class Product
    {
        public void ApplyDiscount(Discount discount)
        {
            this.Money.Amount -= discount.Amount;
        }

        public Money Money { get; set; }
    }

    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }

    public class Discount
    {
        public decimal Amount { get; set; }
    }

}