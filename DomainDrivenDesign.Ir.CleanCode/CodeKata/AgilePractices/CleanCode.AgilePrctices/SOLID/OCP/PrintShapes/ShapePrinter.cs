using System.Collections.Generic;

namespace CleanCode.AgilePractices.SOLID.OCP.PrintShapes
{
    public class ShapePrinter
    {
        public static void DrawAllShapes(List<IShape> shapes)
        {
            //shapes.Sort(new ShapeComp arer());

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}