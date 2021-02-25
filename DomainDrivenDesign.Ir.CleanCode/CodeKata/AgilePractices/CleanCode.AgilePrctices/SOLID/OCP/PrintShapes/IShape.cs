namespace CleanCode.AgilePractices.SOLID.OCP.PrintShapes
{
    public class Rectangle : IShape
    {
        public override void Draw()
        {
        }
    }

    public class Circle : IShape
    {
        public override void Draw()
        {
        }
    }

    public class Square : IShape
    {
        public override void Draw()
        {
        }
    }


    public abstract class IShape
    {
        public abstract void Draw();
    }
}