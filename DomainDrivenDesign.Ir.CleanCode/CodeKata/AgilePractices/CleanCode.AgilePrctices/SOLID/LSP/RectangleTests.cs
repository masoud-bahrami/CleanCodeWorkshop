using System.Runtime.ConstrainedExecution;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.LSP
{
    public class RectangleTests
    {
        [Fact]
        public void CalculateArea()
        {
            Rectangle rec = new Square();
            rec.Width = 4;
            rec.Height = 5;
            if (rec.GetType() == typeof(Square))
                Assert.Equal(10, rec.Area());
            else Assert.Equal(25, rec.Area());
        }
    }
}