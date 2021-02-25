using System;
using System.Collections.Generic;
using Xunit;

namespace CleanCode.AgilePractices.BadSmells._03LongFunction
{
    public class DateInterval
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public  class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string CardNumber { get; set; }
    }
    public class CacheBackServiceTests
    {
        [Fact]
        public void Test()
        {
            Customer customer = new Customer();

            List<Transaction> transactions = new List<Transaction>();
            new CacheBackService().Calculate(new DateInterval(), transactions,customer);
        }
    }
    public class CacheBackService
    {
        public void Calculate(DateInterval summerInterval, 
                                List<Transaction> transactions,
                                Customer customer)
        {

             var quantity = transactions.Count;
            PrintBanner(customer.FirstName , customer.LastName);

            double charge = 0;

            if (!CuurentDate().IsBefore(summerInterval.Start) && !CuurentDate().IsAfter(summerInterval.End))
                charge = quantity * .009;
            else
                charge = quantity * .0009;

            double totalCacheBack = 0;

            string result = "";

            foreach (var transaction in transactions)
            {
                totalCacheBack += CalculateCacheBackFor(transaction);
            }

            foreach (var transaction in transactions)
            {
                result += $"{transaction.CardType} - {transaction.TransactionType} - {transaction.Amount}. Your earned {CalculateCacheBackFor(transaction)} Toman \n";
            }

            totalCacheBack += (totalCacheBack * charge) / 100;

            result += $"totalCacheBack you earned {totalCacheBack}";
            
            
            Print(result);

            Console.WriteLine("**** Take care your-self****");
            Console.WriteLine("**** GoodBy **********");
        }

        private double CalculateCacheBackFor(Transaction transaction)
        {
            decimal cacheBack = 0;
            switch (transaction.CardType)
            {
                case CardType.GoldCard:
                    if (transaction.TransactionType == TransactionType.Hotel)
                    {
                        cacheBack = 25000;
                    }
                    else if (transaction.TransactionType == TransactionType.Restaurant)
                    {
                        cacheBack = 15000;
                    }
                    else if (transaction.TransactionType == TransactionType.CarRental)
                    {
                        cacheBack = 35000;
                    }

                    break;
                case CardType.SilverCard:
                    if (transaction.TransactionType == TransactionType.Hotel)
                    {
                        cacheBack = 20000;
                    }
                    else if (transaction.TransactionType == TransactionType.Restaurant)
                    {
                        cacheBack = 10000;
                    }
                    else if (transaction.TransactionType == TransactionType.CarRental)
                    {
                        cacheBack = 30000;
                    }

                    break;
                case CardType.BronzeCard:
                    if (transaction.TransactionType == TransactionType.Hotel)
                    {
                        cacheBack = 15000;
                    }
                    else if (transaction.TransactionType == TransactionType.Restaurant)
                    {
                        cacheBack = 9500;
                    }
                    else if (transaction.TransactionType == TransactionType.CarRental)
                    {
                        cacheBack = 27500;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return (double) cacheBack;
        }

        private void Print(string message)
        {
            Console.WriteLine(message);
        }

        private void PrintBanner(string firstName, string lastName)
        {

            Console.WriteLine($"**** Welcome {firstName} {lastName} *****");
            Console.WriteLine("**** BigCompany ***");
        }

        private DateTime CuurentDate()
        {
            return DateTime.Now;
        }
    }

    public abstract class Transaction
    {
        public CardType CardType { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }

        public abstract void Accept(IVisitor visitor);
    }

    public class GoldCardTransaction : Transaction
    {
        public override void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
    
    public class BronzeCardTransaction : Transaction
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public enum TransactionType
    {
        Hotel,
        Restaurant,
        CarRental
    }

    public enum CardType
    {
        GoldCard,
        SilverCard,
        BronzeCard
    }
}