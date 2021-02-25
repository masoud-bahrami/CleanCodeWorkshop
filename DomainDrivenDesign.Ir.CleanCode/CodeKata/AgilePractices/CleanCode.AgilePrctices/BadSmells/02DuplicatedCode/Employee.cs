namespace CleanCode.AgilePractices.BadSmells._02DuplicatedCode
{
    public class Employee
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFulName()
        {
            return $"{FirstName} - {LastName}";
        }
    }

    public class Salesman : Employee
    {
    }
    public class Engineer : Employee
    {
        
    }
}