using MetroApp.Exceptions;
using MetroApp.Visitor;

namespace MetroApp
{
    public class ChargableMetroCard : MetroCard
    {
        private decimal _balance;

        public ChargableMetroCard(decimal initialAmount)
        {
            _balance = initialAmount;
        }

        public override bool IsExpired()
        {
            return false;
        }

        public override void Visit(MetroCardVisitor metroCardVisitor)
        {
            metroCardVisitor.Accept(this);
        }

        public decimal Balance() => _balance;

        public void WithDraw(int amount)
        {
            AssertThatThereIsEnoughBalance(amount);

            _balance -= amount;
        }

        private void AssertThatThereIsEnoughBalance(int amount)
        {
            if (_balance - amount < 0)
                throw new CarBalanceIsNotEnoughException();
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
    }
}