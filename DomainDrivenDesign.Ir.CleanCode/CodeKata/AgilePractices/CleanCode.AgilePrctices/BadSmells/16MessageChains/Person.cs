namespace CleanCode.AgilePractices.BadSmells._16MessageChains
{
    public class Person
    {
        public Department Department { get; set; }

    }

    public class Department
    {
        public  Person Manager { get; set; }
    }
}