using System;
using System.Collections.Generic;

namespace CleanCode.AgilePractices.SOLID.ISP
{
    public interface Successor
    {
        DateTime LatestStart();
    }
    public interface Predecessor
    {
        DateTime EarliestFinish();
    }

    public interface IActivity
    {
        DateTime EarliestStart();
        DateTime LatestStart();
        DateTime EarliestFinish();
        DateTime LatestFinish();
    }

    class Activity : IActivity
    {
        private int duration;

        private IList<IActivity> predecessors;
        private IList<IActivity> successors;
        public DateTime EarliestStart()
        {
            DateTime result = DateTime.MinValue;

            foreach (var s in successors)
                if (s.LatestFinish() <= result)
                    result = s.LatestFinish();
            return result;
        }

        public DateTime EarliestFinish()
        {
            return EarliestStart().AddDays(duration);

        }

        public DateTime LatestFinish()
        {
            DateTime result = DateTime.MinValue;

            foreach (var s in successors)
                if (s.LatestStart() <= result)
                    result = s.LatestStart();
            return result;
        }

        public DateTime LatestStart()
        {
            return LatestFinish().AddDays(-duration);

        }
    }
}
