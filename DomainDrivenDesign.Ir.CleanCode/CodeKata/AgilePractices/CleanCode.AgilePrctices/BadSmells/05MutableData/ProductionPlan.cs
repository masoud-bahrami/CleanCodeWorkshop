using System.Collections.Generic;

//Replace Derived Variable With Query

namespace CleanCode.AgilePractices.BadSmells._05MutableData
{

    public class ProductionPlan
    {
        private readonly List<Adjustment> _adjustments;
        private decimal _production;

        public ProductionPlan(List<Adjustment> adjustments)
        {
            _adjustments = adjustments;
        }

        public decimal Production()
        {
            return _production;
        }

        public void ApplyAdjustment(Adjustment anAdjustment)
        {
            this._adjustments.Add(anAdjustment);
            this._production += anAdjustment.Amount;
        }
    }

    public class Adjustment
    {
        public decimal Amount;
    }
}