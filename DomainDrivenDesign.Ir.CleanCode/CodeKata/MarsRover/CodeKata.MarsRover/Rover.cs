namespace CodeKata.MarsRover
{
    internal partial class Rover
    {
        internal string Execute(string commands)
        {
            AssertThatCommansAreValid(commands);
            Direction myDirection = new Direction(DirectionBase.North());
            foreach (var command in commands.ToCharArray())
            {
                if (command == 'R')
                    myDirection = myDirection.RotateRight();
                else
                    myDirection = myDirection.RotateLeft();
            }
            return $"0:0:{myDirection.Symbol()}";
        }
        
        private void AssertThatCommansAreValid(string commands)
        {
            //Refactor
            //
            foreach (var command in commands.ToCharArray())
            {
                if (command != 'L' && command != 'R')
                    throw new InvalidRowerCommandException();
            }
        }
    }
}