using MetroApp.Strategy;

namespace MetroApp.UnitTests.TestSpecificClasses
{
    public class CacheBackForChargeByPosDevicesStrategyStub : CacheBackForChargeByPosDevicesStrategy
    {
        private readonly decimal _cacheBackPercentage;

        public CacheBackForChargeByPosDevicesStrategyStub(decimal amount, decimal cacheBackPercentage) : base(amount)
        {
            _cacheBackPercentage = cacheBackPercentage;
        }

        protected override decimal CacheBackPercentage()
        {
            return _cacheBackPercentage;
        }

        protected override int EligibleForCacheBack()
        {
            return 5000;
        }
    }
}