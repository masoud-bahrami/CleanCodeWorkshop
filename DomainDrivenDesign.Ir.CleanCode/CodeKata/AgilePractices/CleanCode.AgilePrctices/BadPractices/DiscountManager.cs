namespace CleanCode.AgilePractices.BadPractices
{
    //public enum AccountStatus
    //{
    //    NotRegistered = 1,
    //    SimpleCustomer = 2,
    //    ValuableCustomer = 3,
    //    MostValuableCustomer = 4
    //}
    //discountForLoyaltyInPercentage 

    // public decimal Apply(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)

    /// <summary>
    /// https://www.codeproject.com/Articles/1083348/Csharp-Bad-Practices-Learn-How-to-Make-Good-Code-b
    /// </summary>
    public class DiscountManager
    {
        public decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            
            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }
    }
}