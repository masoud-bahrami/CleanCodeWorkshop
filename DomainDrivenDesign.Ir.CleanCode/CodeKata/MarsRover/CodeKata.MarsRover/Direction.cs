namespace CodeKata.MarsRover
{
    class Direction
    {
        DirectionBase DirectionBase = DirectionBase.North();
        public Direction(DirectionBase directionBase)
        {
            DirectionBase = directionBase;
        }
        internal Direction RotateLeft()
        {
            return new Direction( DirectionBase.RotateLeft());
        }


        internal Direction RotateRight()
        {
            return new Direction(DirectionBase.RotateRight());

        }

        internal object Symbol()
        {
            return DirectionBase.Symbol();
        }
    }
}
