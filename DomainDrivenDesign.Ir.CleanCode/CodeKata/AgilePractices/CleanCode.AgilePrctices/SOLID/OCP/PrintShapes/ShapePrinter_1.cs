//using System.Collections.Generic;

//namespace CleanCode.AgilePractices.SOLID.OCP.PrintShapes
//{
//    public class Circle 
//    {
//        public void Draw()
//        {
//        }
//    }

//    public class Square 
//    {
//        public void Draw()
//        {
//        }
//    }

//    public class Rectangle 
//    {
//        public void Draw()
//        {
//        }
//    }

//    public class ShapePrinter
//    {
//        public static void DrawAllShapes(List<object> shapes)
//        {
//            foreach (var shape in shapes)
//            {
//                switch (shape)
//                {
//                    case Circle c:
//                        DrawCircle(c);
//                        break;
//                    case Rectangle r:
//                        DrawRectangle(r);
//                        break;
//                    case Square s:
//                        DrawSquare(s);
//                        break;
//                }
//            }
//        }

//        private static void DrawRectangle(Rectangle rectangle) => rectangle.Draw();
//        private static void DrawSquare(Square square) => square.Draw();
//        private static void DrawCircle(Circle circle) => circle.Draw();
//    }
//}