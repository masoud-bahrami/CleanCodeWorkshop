using System;

namespace CleanCode.AgilePractices.BadSmells._06DivergentChange
{
    public class Account
    {

        private string _type;
        private string _accountNumber;
        private int _amount;

        public Account(string type, string accountNumber, int amount)
        {
            this._amount = amount;
            this._type = type;
            this._accountNumber = accountNumber;
        }


        public void Debit(int debit)
        {
            if (_amount <= 500)
            {
                throw new Exception("Minimum balance should be over 500");
            }

            _amount = _amount - debit;
            Console.WriteLine("Now amount is" + _amount);

        }

        public void SendWarningMessage()
        {
            if (_amount <= 500)
            {
                Console.WriteLine("amount should be over 500");
            }
        }
    }
}