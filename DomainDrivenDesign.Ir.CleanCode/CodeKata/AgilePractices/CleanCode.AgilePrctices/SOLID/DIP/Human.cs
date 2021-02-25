using System;
using System.Runtime.InteropServices;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.DIP
{
    public class HumanShould
    {
        [Fact]
        public void EatSteak()
        {
            var human = new Human();
            var steak = new Steak();
            human.Eat(steak);

            Chicken chicken = new Chicken();
            human.Eat(chicken);
        }
    }

    public class Human
    {
        private bool _isHungry;
        
        public void Eat(IMeat meat)
        {
            if (!_isHungry)
                throw new Exception();

            //Eat the meat
            _isHungry = true;
        }

     
    }

    public interface IMeat
    {
    }

    public class Chicken : IMeat
    {

    }
    public class Steak : IMeat
    {
    }
}