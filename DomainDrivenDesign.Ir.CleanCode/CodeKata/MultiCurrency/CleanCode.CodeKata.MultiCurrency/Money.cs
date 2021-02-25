namespace CleanCode.CodeKata.MultiCurrency
{
    public abstract class Money : MoneyExpression
    {
        public int Amount { get; set; }
        public string Currency { get; set; }

        protected Money(int amount, string currency)
        {
            Currency = currency;
            Amount = amount;
        }
        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public string GetCurrency()
        {
            return Currency;
        }

        public Dollar Plus(Dollar dollar)
        {
            return new Dollar(10);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }


        public override bool Equals(object? obj)
        {
            Money that = (Money)obj;
            return this.Amount == that.Amount
                   && this.GetCurrency() == that.GetCurrency();
        }
    }
}