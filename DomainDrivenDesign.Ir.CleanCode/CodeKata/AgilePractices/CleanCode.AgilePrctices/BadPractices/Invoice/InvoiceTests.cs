using System.Collections.Generic;
using Xunit;

namespace CleanCode.AgilePractices.BadPractices.Invoice
{
    public class InvoiceTests
    {
        [Fact]
        public void TestInvoiceStatement()
        {
            var performances = new List<Performance>
            {
                new Performance {PlayId = "Othello", Audience = 50},
                new Performance {PlayId = "as-like", Audience = 100}
            };
            var invoice = new Invoice("Company", performances);

            var plays = new List<Play>
            {
                new Play
                {
                    Type = PlayType.Tragedy,
                    Name = "Othello",
                    PlayId= "Othello",
                },
                new Play
                {
                    Type = PlayType.Comedy,
                    Name = "As you like it",
                    PlayId= "as-like",
                }
            };

            var statement = invoice.Statement(plays);

            Assert.Equal("Statement for Company\nOthello: 600 50As you like it: 1100 100Amount owed is 1700\nYor earned 110 credits\n", statement);
        }
    }
}