

//Replace Type-code with sub classes

namespace CleanCode.AgilePractices.BadSmells._10Primitive_Obsession
{
    
    public class EmployeeFactory
    {
        public Employee CreateEmployee(string name, EmployeeType type)
        {
            return new Employee { _name = name, Type = type };
        }
    }

    public class Employee
    {
        public string _name { get; set; }
        public EmployeeType Type { get; set; }
    }

    public enum EmployeeType
    {
        Engineer,
        SalesMan,
        Manager
    }
}