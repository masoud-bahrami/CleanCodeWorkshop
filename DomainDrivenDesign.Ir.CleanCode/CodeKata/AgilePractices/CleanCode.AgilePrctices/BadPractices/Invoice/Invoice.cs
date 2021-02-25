using System.Collections.Generic;
using System.Linq;

namespace CleanCode.AgilePractices.BadPractices.Invoice
{
    public class StatementCalculator
    {
        private List<Play> _plays;
        private Invoice _invoice;

        public StatementCalculator(List<Play> plays, Invoice invoice)
        {
            _plays = plays;
            _invoice = invoice;
        }

        public string Statement() => RawStatement(CreateStatementData());
        public string HtmlFormattedStatement() => RawStatement(CreateStatementData());

        private string HtmlStatement(StatementData data)
        {
            string result = $"Statement for {data.Customer}\n";

            foreach (var perf in data.Performances)
            {
                //print line for this order
                result += $"{perf.PlayName}: {perf.Amount} {perf.Audience}";
            }

            result += $"Amount owed is {data.TotalAmount}\n";
            result += $"Yor earned {data.TotalCredits} credits\n";

            return result;
        }

        private string RawStatement(StatementData data)
        {
            string result = $"Statement for {data.Customer}\n";

            foreach (var perf in data.Performances)
            {
                //print line for this order
                result += $"{perf.PlayName}: {perf.Amount} {perf.Audience}";
            }

            result += $"Amount owed is {data.TotalAmount}\n";
            result += $"Yor earned {data.TotalCredits} credits\n";

            return result;
        }

        private StatementData CreateStatementData()
        {
            var performanceCalculator = CreatePerformanceCalculator();

            return new StatementData
            {
                Customer = _invoice.Customer,
                TotalAmount = performanceCalculator.TotalAmount() / 100,
                TotalCredits = performanceCalculator.VolumeCredits(),
                Performances = _invoice.Performances.Select( p=> ToPerformanceDto(p , performanceCalculator)).ToList()
            };
        }

        private PerformanceCalculator CreatePerformanceCalculator()
        {
            return new PerformanceCalculator(_invoice , _plays);
        }

        private PerformanceDto ToPerformanceDto(Performance p , PerformanceCalculator performanceCalculator )
        {
            return new PerformanceDto
            {
                Audience = p.Audience,
                PlayId = p.PlayId,
                PlayName = performanceCalculator.PlayFor(p).Name,
                Amount = performanceCalculator.AmountFor(p) / 100
            };
        }

        
    }

    public class StatementData
    {
        public string Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalCredits { get; set; }
        public List<PerformanceDto> Performances { get; set; }
    }

    public class PerformanceDto
    {
        public int Audience { get; set; }
        public string PlayId { get; set; }
        public string PlayName { get; set; }
        public decimal Amount { get; set; }
    }

    public class Invoice
    {
        private List<Play> _plays;
        public string Customer { get; private set; }
        public List<Performance> Performances { get; private set; }

        public Invoice(string customer, List<Performance> performances)
        {
            Customer = customer;
            Performances = performances;
        }


        public string Statement(List<Play> plays)
        {
            return new StatementCalculator(plays, this).Statement();

        }

    }

    public class Play
    {
        public string Name { get; set; }
        public PlayType Type { get; set; }
        public string PlayId { get; set; }
    }

    public enum PlayType
    {
        Tragedy,
        Comedy
    }

    public class Performance
    {
        public string PlayId { get; set; }
        public int Audience { get; set; }
    }
}