using System;
using MetroApp.Strategy;

namespace MetroApp.Observer
{
    public class ChargeMetroCardObserver : IObserver<ChargeMetroCardViewModel>
    {
        public void Update(ChargeMetroCardViewModel data)
        {
            var cacheBackStrategy = CreateCacheBackStrategy(data.ChargeBy , data.Amount);

            var cacheBack = cacheBackStrategy.CacheBack();
            data.Card.Deposit(cacheBack);
        }

        protected  virtual ICacheBackStrategy CreateCacheBackStrategy(ChargeBy data , decimal amount)
        {
            switch (data)
            {
                case ChargeBy.ByPos:
                    return new CacheBackForChargeByPosDevicesStrategy(amount);
                case ChargeBy.ByMobile:
                    return new CacheBackForChargeByMobileStrategy(amount);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}