namespace CleanCode.CodeKata.MultiCurrency
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        :base(amount, "Dollar")
        {
        }

        public override void Add(MoneyExpression dollar, MoneyExpression moneyExpression)
        {
            
        }

        public override Money Reduce()
        {
            return null;
        }
    }
}