using MetroApp.Observer;
using MetroApp.Strategy;

namespace MetroApp.UnitTests.TestSpecificClasses
{
    public class ChargeMetroCardObserverStub: ChargeMetroCardObserver
    {
        private readonly decimal _amount;
        private readonly decimal _cacheBackPercentage;

        public ChargeMetroCardObserverStub(decimal amount, decimal cacheBackPercentage)
        {
            _amount = amount;
            _cacheBackPercentage = cacheBackPercentage;
        }

        protected override ICacheBackStrategy CreateCacheBackStrategy(ChargeBy data, decimal amount)
        {
            return new CacheBackForChargeByPosDevicesStrategyStub(_amount, _cacheBackPercentage);
        }
    }
}