using System.Linq;

namespace CleanCode.AgilePractices.OOP
{
    
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {

        }
    }
}