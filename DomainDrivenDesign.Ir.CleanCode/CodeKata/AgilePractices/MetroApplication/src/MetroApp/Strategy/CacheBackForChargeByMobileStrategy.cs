namespace MetroApp.Strategy
{
    public class CacheBackForChargeByMobileStrategy : ICacheBackStrategy
    {
        private readonly decimal _amount;

        public CacheBackForChargeByMobileStrategy(decimal amount)
        {
            _amount = amount;
        }

        public decimal CacheBack()
        {
            return 0;
        }
    }
}