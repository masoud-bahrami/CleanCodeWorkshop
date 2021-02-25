namespace CleanCode.AgilePractices.BadSmells._01MysteriousNames
{
    public class Invoice
    {
        public int ItemsCount { get; set; }
        public int GetInvoiceLimit()
        {
            return default;
        }

        
    }
}