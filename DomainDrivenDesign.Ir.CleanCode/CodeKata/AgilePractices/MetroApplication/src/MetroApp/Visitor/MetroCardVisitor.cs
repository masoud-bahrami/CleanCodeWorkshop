namespace MetroApp.Visitor
{
    public class MetroCardVisitor
    {
        public void Accept(MultiTripsCard card) => card.CountDownNumberOfAllowedTrips();

        public void Accept(ChargableMetroCard card) => card.WithDraw(Amount());

        private int Amount() => 10000;
    }
}