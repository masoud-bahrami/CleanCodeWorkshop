namespace CleanCode.AgilePractices.BadSmells._05MutableData
{
    public class Telephone
    {
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }
    }

    public class Employee
    {
        public Telephone Telephone { get; set; }

        public void ChangeOfficeAreaCode(string newOfficeAreaCode)
        {
            Telephone.OfficeAreaCode = newOfficeAreaCode;
        }

        public void ChangeOfficeNumber(string newOfficeNumber)
        {
            Telephone.OfficeAreaCode = newOfficeNumber;
        }

    }
}