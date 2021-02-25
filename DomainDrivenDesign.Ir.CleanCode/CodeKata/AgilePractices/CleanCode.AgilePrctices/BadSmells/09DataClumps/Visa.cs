namespace CleanCode.AgilePractices.BadSmells._09DataClumps
{
    public class Visa
    {
        public decimal PriceAmount { get; set; }
        public string PriceCurrency { get; set; }

        public void SetPrice(decimal amount, string currency)
        {
            PriceAmount = amount;
            PriceCurrency = currency;
        }
    }

    public class TourismHealthService
    {
        public decimal PriceAmount { get; set; }
        public string PriceCurrency { get; set; }

        public void SetPrice(decimal amount, string currency)
        {
            PriceAmount = amount;
            PriceCurrency = currency;
        }
    }
}
