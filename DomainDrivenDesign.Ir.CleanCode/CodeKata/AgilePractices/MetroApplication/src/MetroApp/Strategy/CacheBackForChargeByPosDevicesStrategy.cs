namespace MetroApp.Strategy
{
    public class CacheBackForChargeByPosDevicesStrategy : ICacheBackStrategy
    {
        private readonly decimal _amount;

        public CacheBackForChargeByPosDevicesStrategy(decimal amount)
        {
            _amount = amount;
        }

        public decimal CacheBack()
        {
            if (_amount > EligibleForCacheBack())
                return (_amount * CacheBackPercentage());
            
            return DefaultCacheBack();
        }


        protected virtual decimal CacheBackPercentage()
        {
            return .005M;
        }
        protected virtual int EligibleForCacheBack()
        {
            var Threshold = 5000;
            return Threshold;
        }
        private decimal DefaultCacheBack() => 0;
    }
}