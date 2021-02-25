namespace CleanCode.AgilePractices.BadSmells._03LongFunction
{
    public interface IVisitor
    {
        decimal Visit(GoldCardTransaction transaction);
        decimal Visit(BronzeCardTransaction transaction);
    }

    public class HotelVisitor : IVisitor
    {
        public decimal Visit(GoldCardTransaction transaction)
        {
            return 25000;
        }

        public decimal Visit(BronzeCardTransaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }
}