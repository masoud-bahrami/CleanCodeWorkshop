namespace MetroApp.Proxy
{
    public interface IChargeMetroCardProxy
    {
        void Withdraw(string bankCardNumber, string password, decimal amount);
    }

    public class ChargeMetroCardProxy : IChargeMetroCardProxy
    {
        public void Withdraw(string bankCardNumber, string password, decimal amount)
        {
            
        }
    }
}