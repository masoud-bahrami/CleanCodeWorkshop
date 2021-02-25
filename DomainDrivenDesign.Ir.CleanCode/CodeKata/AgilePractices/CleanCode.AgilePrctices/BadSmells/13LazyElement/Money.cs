namespace CleanCode.AgilePractices.BadSmells._13LazyElement
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money(decimal amount , string currency)
        {
            Currency = currency;
            Amount = amount;
        }
    }

    public class Franc :Money
    {
        public Franc(decimal amount, string currency) : base(amount, currency)
        {
        }
    }

    public class Dollar: Money
    {
        public Dollar(decimal amount, string currency) : base(amount, currency)
        {
        }
    }
}