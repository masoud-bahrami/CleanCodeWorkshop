using MetroApp.Visitor;

namespace MetroApp
{
    public class MultiTripsCard : MetroCard
    {
        private int _trips;

        public MultiTripsCard(int trips)
        {
            _trips = trips;
        }
        public override bool IsExpired()
        {
            return _trips < 1;
        }

        public override void Visit(MetroCardVisitor metroCardVisitor)
        {
            metroCardVisitor.Accept(this);
        }

        public int AllowedTrips()
        {
            return _trips;
        }

        public void CountDownNumberOfAllowedTrips()
        {
            --_trips;
        }
    }
}