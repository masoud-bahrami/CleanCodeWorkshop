using System.Drawing;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.LSP
{
   
    //Square is a specific Rectangle
    //Inheritance
    // IS A behavior
    public class Rectangle
    {
        private decimal height;
        private decimal width;

        private Point LeftPoint;

        public virtual decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public virtual decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public decimal Area()
        {
            //TODO
            return Height * Width ;
        }
    }


    public class Square : Rectangle
    {
        private Point LeftPoint;

        public override decimal Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public override decimal Width
        {
            get => base.Width;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public  decimal Area()
        {
            //TODO
            return 10;
        }
    }
}