namespace CleanCode.AgilePractices.BadPractices
{
    public class Description
    {
        public Description(string faDescription, string enDescription, string arDescription)
        {
            FaDescription = faDescription;
            EnDescription = enDescription;
            ArDescription = arDescription;
        }

        public string FaDescription { get; private set; }
        public string EnDescription { get; private set; }
        public string ArDescription { get; private set; }
    }

    public class Post
    {
        private readonly Description _description;
        public int Id { get; private set; }
        public string Text { get; private set; }

        //Data Clumps

            //Simple Design
            //Reasoning About
        public Post(int id, string text, Description description)
        {
            Id = id;
            Text = text;
            _description = description;
        }


    }
}