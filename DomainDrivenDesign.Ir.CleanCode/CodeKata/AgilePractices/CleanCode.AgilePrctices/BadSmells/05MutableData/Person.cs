namespace CleanCode.AgilePractices.BadSmells._05MutableData
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}