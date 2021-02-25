using MetroApp.Command;
using MetroApp.Observer;

namespace MetroApp.Template
{
    public class ChargeMetroCardFacade
    {
        private readonly IChargeMetroCardTemplate _chargeMetroCardTemplate;
        private readonly ChargeMetroCardSubject _chargeMetroCard;
        public ChargeMetroCardFacade(IChargeMetroCardTemplate chargeMetroCardTemplate, ChargeMetroCardSubject chargeMetroCard)
        {
            _chargeMetroCardTemplate = chargeMetroCardTemplate;
            _chargeMetroCard = chargeMetroCard;
        }

        public void Charge()
        {
            _chargeMetroCardTemplate.SwipeYourBankCard();
            _chargeMetroCardTemplate.EnterAmount();
            _chargeMetroCardTemplate.EnterPassword();
            _chargeMetroCardTemplate.ProcessBankInfo();
            var chargeMetroCard = _chargeMetroCardTemplate.PlaceYourCardInFrontOfTheCardReader();

            _chargeMetroCard.NotifyObservers(ToChargeMetroCardViewModel(chargeMetroCard));
        }

        private static ChargeMetroCardViewModel ToChargeMetroCardViewModel(ChargeMetroCard chargeMetroCard)
        {
            return new ChargeMetroCardViewModel
            {
                Amount = chargeMetroCard.Amount,
                ChargeBy = ChargeBy.ByPos,
                Card = chargeMetroCard.Card
            };
        }
    }
    public interface IChargeMetroCardTemplate
    {
        void SwipeYourBankCard();
        void EnterPassword();
        void EnterAmount();
        void ProcessBankInfo();
        ChargeMetroCard PlaceYourCardInFrontOfTheCardReader();
    }
}