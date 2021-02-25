using System.Collections.Generic;

namespace MetroApp.Template
{
    public class ChargeCardWriterCompositeUi : IChargeCardWriterUi
    {
        private readonly IList<IChargeCardWriterUi> _cardWriterUis;

        public ChargeCardWriterCompositeUi(IList<IChargeCardWriterUi> uis) => _cardWriterUis = uis;

        public void SwipeYouBankCard()
        {
            foreach (var cardWriterUi in _cardWriterUis) cardWriterUi.SwipeYouBankCard();
        }

        public void PrintEnterPassword()
        {
            foreach (var cardWriterUi in _cardWriterUis) cardWriterUi.PrintEnterPassword();
        }

        public void PrintEnterAmount()
        {
            foreach (var cardWriterUi in _cardWriterUis) cardWriterUi.PrintEnterAmount();
        }

        public void PrintChargeResult()
        {
            foreach (var cardWriterUi in _cardWriterUis) cardWriterUi.PrintChargeResult();
        }
    }
}