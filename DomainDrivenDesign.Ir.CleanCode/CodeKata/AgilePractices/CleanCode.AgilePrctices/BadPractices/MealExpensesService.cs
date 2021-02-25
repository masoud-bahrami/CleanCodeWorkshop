using System;

namespace CleanCode.AgilePractices.BadPractices
{
    public class MealExpensesService
    {
        public ExpenseReportDAO _expenseReportDAO { get; set; }

        public decimal GetTotal(int employeeId) => _expenseReportDAO.CalculateTotalMealExpenses(employeeId);
    }

    public class ExpenseReportDAO
    {
        public MealExpenses GetMeals(int employeeId)
        {
            // throw exception if MealExpenses not found!
            //throw new MealExpensesNotFoundException();

            //Special-Case Object
            return MealExpenses.GetMealPerDiem();
        }

        public decimal CalculateTotalMealExpenses(int employeeId)
        {
            return GetMeals(employeeId).GetTotal();
        }
    }

    public class MealExpenses
    {
        public static MealExpenses GetMealPerDiem() => new MealPerDiem();

        private class MealPerDiem : MealExpenses
        {
            public override decimal GetTotal()
            {
                return 5000;
            }
        }
        public virtual decimal GetTotal()
        {
            return 50000;
        }
    }

    public class MealExpensesNotFoundException : Exception
    {
    }
}