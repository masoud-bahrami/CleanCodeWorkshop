using System.Reflection.Metadata;
using Xunit;

namespace CleanCode.CodeKata.MultiCurrency
{
    public class MultiCurrencyTests
    {
        [Fact]
        public void TestMultiplication()
        {
            //$5 * 2 = $10
            Money five = Money.Dollar(5);

            Assert.Equal(Money.Dollar(10),
                five.Times(multiplier: 2));
            Assert.Equal(Money.Dollar(15),
                five.Times(multiplier: 3));
        }
        [Fact]
        public void TestEquality()
        {
            Assert.Equal(Money.Dollar(5), Money.Dollar(5));
            Assert.NotEqual(Money.Dollar(5), Money.Dollar(7));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            //$5 * 2 = $10
            Money five = Money.Franc(5);

            Assert.Equal(Money.Franc(10), five.Times(multiplier: 2));

            Assert.Equal(Money.Franc(15), five.Times(multiplier: 3));
        }

        [Fact]
        public void TestFrancEquality()
        {
            Assert.Equal(Money.Franc(5), Money.Franc(5));
            Assert.NotEqual(Money.Franc(5), Money.Franc(7));
        }

        [Fact]
        public void TestSimpleDollarAddition()
        {
            //$5 + $5
            //(($5 + 10 CHF) + 10000000000 Rial) * 10 
            // Exchange Rate
            // Reduce
            MoneyExpression dollar = Money.Dollar(5);
            MoneyExpression plus = new PlusExpression();

            plus.Add(dollar, dollar);
            Money result = plus.Reduce();
            Assert.Equal(Money.Dollar(10), result);
        }
    }

    public class PlusExpression : MoneyExpression
    {
        public override void Add(MoneyExpression dollar, MoneyExpression moneyExpression)
        {
            throw new System.NotImplementedException();
        }

        public override Money Reduce()
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class MoneyExpression
    {
        public abstract void Add(MoneyExpression dollar, MoneyExpression moneyExpression);

        public abstract Money Reduce();
    }
}