namespace CleanCode.AgilePractices.SOLID.LSP
{
    public class RectangleFactory
    {
        public Rectangle GetRectangle()
        {
            return new Rectangle();
        }
    }

    public class SquareFactory : RectangleFactory
    {
        public new Rectangle GetRectangle()
        {
            return new Square();
        }
    }

}