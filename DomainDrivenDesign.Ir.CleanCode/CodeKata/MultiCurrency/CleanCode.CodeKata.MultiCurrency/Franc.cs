namespace CleanCode.CodeKata.MultiCurrency
{
    public class Franc : Money
    {
        public Franc(int amount)
        :base(amount, "CHF")
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