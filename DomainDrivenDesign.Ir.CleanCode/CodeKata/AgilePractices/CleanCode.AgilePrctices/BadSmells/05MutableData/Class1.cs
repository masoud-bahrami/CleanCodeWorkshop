using System;

namespace CleanCode.AgilePractices.BadSmells._05MutableData
{
    public class Class1
    {
        public decimal Discount(decimal inputValue, int quantity)
        {
            if (inputValue > 50) inputValue = inputValue - 2;
            if (quantity > 100) inputValue = inputValue - 1;
            return inputValue;
        }

        public double DistanceTravelled(Scenario scenario, int time)
        {
            double acc = scenario.PrimaryForce / scenario.Mass;
            double primaryTime = Math.Min(time, scenario.Delay);

            var result = 0.5 * acc * primaryTime * primaryTime;

            double secondaryTime = time - scenario.Delay;
            if (secondaryTime > 0)
            {
                double primaryVelocity = acc * scenario.Delay;

                acc = (scenario.PrimaryForce + scenario.SecondaryForce) / scenario.Mass;
                result += primaryVelocity * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
            }

            return result;
        }
    }

    public class Scenario
    {
        public double Mass;
        public double PrimaryForce;
        public int Delay;
        public double SecondaryForce;
    }
}