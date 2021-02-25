using MetroApp.Command;

namespace MetroApp.Template
{
    public class ChargeCardReaderUiStub : IChargeCardReaderUi
    {
        private readonly ChargeMetroCard _chargeMetroCard;

        private ChargeCardReaderUiStub(ChargeMetroCard chargeMetroCard) => _chargeMetroCard = chargeMetroCard;

        public static ChargeCardReaderUiStub Config(ChargeMetroCard card) => new ChargeCardReaderUiStub(card);

        public string GetBankCardInfo() => _chargeMetroCard.BankCardNumber;

        public string GetEnteredPassword() => _chargeMetroCard.Password;

        public decimal GetEnteredAmount() => _chargeMetroCard.Amount;

        public ChargableMetroCard GetMetroCardInfo() => _chargeMetroCard.Card;
    }
}