using System;

namespace CodeKata.MarsRover
{

    class DirectionBase
    {
        private Enumm Enumm;
        private Enumm _left;
        private Enumm _right;

        private string _symbole = "E";

        private DirectionBase(Enumm enumm, Enumm left, Enumm right)
        {
            Enumm = enumm;
            _left = left;
            _right = right;
        }
        internal static DirectionBase North()
        {
            return new DirectionBase(Enumm.North, Enumm.West, Enumm.East)
            {
                _symbole = "N",
            };
        }

        internal static DirectionBase East()
        {
            return new DirectionBase(Enumm.East, Enumm.North, Enumm.South)
            {
                _symbole = "E"
            };
        }
        internal static DirectionBase South()
        {
            return new DirectionBase(Enumm.South, Enumm.East, Enumm.West)
            {
                _symbole = "S"
            };
        }
        internal static DirectionBase West()
        {
            return new DirectionBase(Enumm.West, Enumm.South, Enumm.North)
            {
                _symbole = "W",
            };
        }
        internal DirectionBase RotateRight() => Rotate(_right);
        internal DirectionBase RotateLeft() => Rotate(_left);

        internal string Symbol()
        {
            return _symbole;
        }

        private DirectionBase Rotate(Enumm direction)
        {
            if (direction == Enumm.East)
                return East();
            else if (direction == Enumm.South)
                return South();
            else if (direction == Enumm.West)
                return West();
            else if (direction == Enumm.North)
                return North();

            throw new Exception(direction.ToString());
        }
    }

}