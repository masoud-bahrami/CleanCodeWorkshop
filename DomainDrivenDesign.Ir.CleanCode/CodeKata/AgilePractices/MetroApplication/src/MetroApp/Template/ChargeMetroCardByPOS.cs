using MetroApp.Command;

namespace MetroApp.Template
{
    public class ChargeMetroCardByPOS : IChargeMetroCardTemplate
    {
        private readonly Mediator.Mediator _mediator;
        private readonly IChargeCardWriterUi _writer;
        private readonly IChargeCardReaderUi _reader;

        private string _enteredPassword;
        private decimal _enteredAmount;
        private string _bankCardNumber;

        public ChargeMetroCardByPOS(Mediator.Mediator mediator, IChargeCardWriterUi writer, IChargeCardReaderUi reader)
        {
            _mediator = mediator;
            _writer = writer;
            _reader = reader;
        }
        public void SwipeYourBankCard()
        {
            _writer.SwipeYouBankCard();
            _bankCardNumber = _reader.GetBankCardInfo();
        }

        public void EnterPassword()
        {
            _writer.PrintEnterPassword();
            _enteredPassword = _reader.GetEnteredPassword();
        }

        public void EnterAmount()
        {
            _writer.PrintEnterAmount();
            _enteredAmount = _reader.GetEnteredAmount();
        }

        public void ProcessBankInfo()
        {
        }

        public ChargeMetroCard PlaceYourCardInFrontOfTheCardReader()
        {
            var chargeMetroCard = CreateChargeMetroCard();
            _mediator.Mediat(chargeMetroCard);
            _writer.PrintChargeResult();
            return chargeMetroCard;
        }

        private ChargeMetroCard CreateChargeMetroCard()
        {
            return new ChargeMetroCard
            {
                BankCardNumber = _bankCardNumber,
                Amount = _enteredAmount,
                Password = _enteredPassword,
                Card = _reader.GetMetroCardInfo()
            };
        }
    }
}