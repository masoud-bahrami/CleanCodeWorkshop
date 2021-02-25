namespace CleanCode.AgilePractices.BadSmells._17MiddleMan
{
   
    public class Person
    {
        public Department Department { get; set; }
        public Person GetManager()
        {
            return Department.GetManager();
        }
    }


    public class Department
    {
        private readonly Person _manager;
        public Department(Person manager)
        {
            _manager = manager;
        }
        public Person GetManager()
        {
            return _manager;
        }
    }
}