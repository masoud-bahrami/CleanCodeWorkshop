using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.AgilePractices.SOLID.LSP
{
    // Contravariant
    // Covariant
    public interface IContracvariant<out T>
    {
        T Get();
    }


    public interface IContravarianb<in T>
    {
        void  Set(T t);
    }

    class ContravarianbImpl<T> : IContravarianb<T>
    {
        public void Set(T t)
        {
            
        }
    }

    public class Contracvariant : IContracvariant<Rectangle>
    {
        public Rectangle Get()
        {
            return new Rectangle();
        }
    }

    public abstract class BankCard
    {
        private readonly string name;
        private readonly string cardNumber;
        private readonly DateTime expiryDate;
        protected IList<MyTransaction> Transactions;

        protected BankCard(string name, string cardNumber, DateTime expiryDate)
        {
            //IContravarianb<Rectangle> rectangle = new ContravarianbImpl<Square>();
            // Covariant

            IEnumerable<Rectangle> rectangles = new List<Square>();
            
            Action<Square> square = new Action<Rectangle>(rectangle => Console.Write(rectangles));

            this.name = name;
            this.cardNumber = cardNumber;
            this.expiryDate = expiryDate;
        }

        public void CheckFrauds()
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("name");
            if (string.IsNullOrEmpty(cardNumber))
                throw new Exception("cardNumber");
            if (DateTime.Now <= expiryDate)
                throw new Exception("expiryDate");
        }
    }

    public class MyTransaction
    {
        public bool IsFailed()
        {
            return true;
        }
    }


    public class GiftCard : BankCard
    {
        public GiftCard(string name, string cardNumber, DateTime expiryDate) : base(name, cardNumber, expiryDate)
        {
        }
    }

    public class DebitCard : BankCard
    {

        public DebitCard(string name, string cardNumber, DateTime expiryDate) : base(name, cardNumber, expiryDate)
        {
        }

        public new void CheckFrauds()
        {
            base.CheckFrauds();

            if (Transactions.Any(a => a.IsFailed()))
                throw new Exception("Transaction");
        }
    }
}
