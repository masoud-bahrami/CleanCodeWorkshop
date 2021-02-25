using MetroApp.Proxy;

namespace MetroApp.Command
{
    public class ChargeMetroCardCommand : ICommand
    {
        private readonly ChargeMetroCard _chargeMetroCard;
        private readonly IChargeMetroCardProxy _chargeMetroCardProxy;

        public ChargeMetroCardCommand(ChargeMetroCard chargeMetroCard, IChargeMetroCardProxy chargeMetroCardProxy)
        {
            _chargeMetroCard = chargeMetroCard;
            _chargeMetroCardProxy = chargeMetroCardProxy;
        }

        public void Execute()
        {
            _chargeMetroCardProxy.Withdraw(_chargeMetroCard.BankCardNumber, _chargeMetroCard.Password, _chargeMetroCard.Amount);

            _chargeMetroCard.Card.Deposit(_chargeMetroCard.Amount);
        }
    }
}