using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.AgilePractices.BadPractices.Invoice
{
    public class PerformanceCalculator
    {
        private readonly Invoice _invoice;
        private readonly List<Play> _plays;

        public PerformanceCalculator(Invoice invoice, List<Play> plays)
        {
            _invoice = invoice;
            _plays = plays;
        }

        public decimal TotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var perf in _invoice.Performances)
            {
                totalAmount += AmountFor(perf);
            }

            return totalAmount;
        }

        public virtual decimal AmountFor(Performance perf)
        {
            return CratePerformanceAmountCalculator(perf).AmountFor(perf);
        }

        private PerformanceAmountCalculator CratePerformanceAmountCalculator(Performance perf)
        {
            PerformanceAmountCalculator performanceAmount;
            switch (PlayFor(perf).Type)
            {
                case PlayType.Tragedy:
                    performanceAmount = new TragedyPerformanceAmountCalculator();
                    break;
                case PlayType.Comedy:
                    performanceAmount = new ComedyPerformanceAmountCalculator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return performanceAmount;
        }

        public decimal VolumeCredits()
        {
            decimal result = 0;
            foreach (var perf in _invoice.Performances)
            {
                //Add volume credits
                result += Math.Max(perf.Audience - 30, 0);

                //add extra credit for every ten comedy audiences
                if (PlayType.Comedy == PlayFor(perf).Type)
                    result += perf.Audience / 5;
            }

            return result;
        }

        public Play PlayFor(Performance perf)
        {
            return _plays.FirstOrDefault(a => a.PlayId == perf.PlayId);
        }

    }


    public abstract class PerformanceAmountCalculator
    {
        public abstract decimal AmountFor(Performance perf);
    }

    public class ComedyPerformanceAmountCalculator : PerformanceAmountCalculator
    {
        public override decimal AmountFor(Performance perf)
        {
            var result = 30000;
            if (perf.Audience > 20)
            {
                result += 10000 + 500 * (perf.Audience - 20);
            }

            result += 300 * perf.Audience;
            return result;
        }
    }
    public class TragedyPerformanceAmountCalculator : PerformanceAmountCalculator
    {
        public override decimal AmountFor(Performance perf)
        {
            var result = 40000;
            if (perf.Audience > 30)
            {
                result += 1000 * (perf.Audience - 30);
            }

            return result;
        }
    }
}