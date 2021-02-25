namespace MetroApp.Observer
{
    public class ChargeMetroCardViewModel
    {
        public ChargeBy ChargeBy { get; set; }
        public decimal Amount { get; set; }
        public ChargableMetroCard Card { get; set; }
    }
}