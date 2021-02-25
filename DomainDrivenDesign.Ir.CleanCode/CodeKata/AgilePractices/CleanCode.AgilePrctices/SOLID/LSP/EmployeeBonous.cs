using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.LSP
{
    public class EmployeeBonusTest
    {
        [Fact]
        public void RetrieveBonus()
        {
            Employee bonus = new Employee(400);

            Assert.Equal(400, bonus.GetBonusValue());
        }

    }

    public class NormalEmploye : Employee
    {
        public NormalEmploye(int bonus) : base(bonus)
        {
        }

        public int GetBonusValue()
        {
            return 200;
        }
    }
    public class Employee
    {
        private readonly int _bonus;

        public Employee(int bonus)
        {
            _bonus = bonus;
        }

        public int GetBonusValue()
        {
            return _bonus;
        }
    }
}
