namespace CleanCode.AgilePractices.Smells
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public int CalculateAre()
        {
            
            int a = _width * _height;
            return a;  
        }
    }
}
