namespace CleanCode.AgilePractices.BadPractices
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Rectangle
    {
        private Point _leftUpperPoint;

        public Rectangle(Point leftUpperPoint)
        {
            _leftUpperPoint = leftUpperPoint;
        }
    }
}
