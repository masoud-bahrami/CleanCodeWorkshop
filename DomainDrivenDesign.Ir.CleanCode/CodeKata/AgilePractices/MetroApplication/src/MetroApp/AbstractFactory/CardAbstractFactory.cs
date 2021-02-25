using System;

namespace MetroApp.AbstractFactory
{
    public class CardAbstractFactory
    {
        public MultiTripsCard CreateMultiTripsCard(MultiTripsCardType type)
        {
            switch (type)
            {
                case MultiTripsCardType.OneTrip:
                    return new MultiTripsCard(trips: 1);
                case MultiTripsCardType.TwoTrips:
                    return new MultiTripsCard(trips: 2);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

        }

        public ChargableMetroCard CreateChargableMetroCard(decimal initialAmount)
        {
            return new ChargableMetroCard(initialAmount);
        }
    }
}