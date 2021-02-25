namespace MetroApp.Command
{
    public class ChargeMetroCard
    {
        public string BankCardNumber { get; set; }
        public string Password { get; set; }
        public decimal Amount { get; set; }
        public ChargableMetroCard Card { get; set; }

    }
}