using System;
using System.Collections.Generic;
using Xunit;

namespace CleanCode.AgilePractices.BadPractices
{
    public class EmployeeServiceTests
    {
        [Fact]
        public void TestEmployeePay()
        {
            var paymentService = new PaymentService();
            paymentService.Pay("");
        }
    }
    public class EmployeeRepository
    {
        private List<AbstractEmployee> employees = new List<AbstractEmployee>();
        public AbstractEmployee GetEmployee(string employeeName)
        {
            //check 
            return new NullEmployee();
        }
    }

    public class  NullEmployee : AbstractEmployee
    {
        public override bool IsTimeToPay(DateTime dateTime)
        {
            return false;
        }

        public override void Pay()
        {
        }
    }
    public abstract class AbstractEmployee
    {
        public abstract bool IsTimeToPay(DateTime dateTime);

        public abstract void Pay();
    }

    public class PaymentService
    {
        public void Pay(string employeeName)
        {
            AbstractEmployee employee = new EmployeeRepository().GetEmployee(employeeName);
            if (employee.IsTimeToPay(DateTime.Now))
            {
                employee.Pay();
            }
        }
    }
}