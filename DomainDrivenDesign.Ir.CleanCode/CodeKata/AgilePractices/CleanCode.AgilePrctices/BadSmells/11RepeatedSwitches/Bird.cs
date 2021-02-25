using System;
using System.Collections.Generic;

namespace CleanCode.AgilePractices.BadSmells._11RepeatedSwitches
{
	public class Bird
    {
        private readonly BirdType _birdType;

        public Bird(BirdType type)
        {
            _birdType = type;
        }
        public List<BirdColor> GetColors()
        {
            switch (_birdType)
            {
                case BirdType.Cardinal:
                    return new List<BirdColor>() { BirdColor.Black, BirdColor.Red };
                case BirdType.Goldfinch:
                    return new List<BirdColor>() { BirdColor.Black, BirdColor.Yellow, BirdColor.White };
                case BirdType.Chickadee:
                    return new List<BirdColor>() { BirdColor.Black, BirdColor.White, BirdColor.Tan };
            }
            throw new InvalidBirdTypeException();
        }
        public List<BirdFood> GetFoods()
        {
            switch (_birdType)
            {
                case BirdType.Cardinal:
                    return new List<BirdFood>() { BirdFood.Insects, BirdFood.Seeds, BirdFood.Fruit };
                case BirdType.Goldfinch:
                    return new List<BirdFood>() { BirdFood.Insects, BirdFood.Seeds };
                case BirdType.Chickadee:
                    return new List<BirdFood>() { BirdFood.Insects, BirdFood.Fruit, BirdFood.Seeds };
            }
            throw new InvalidBirdTypeException();
        }
        public BirdSizeRange GetSizeRange()
        {
            switch (_birdType)
            {
                case BirdType.Cardinal:
                    return new BirdSizeRange() { Lower = 8, Upper = 9 };
                case BirdType.Goldfinch:
                    return new BirdSizeRange() { Lower = 4.5, Upper = 5.5 };
                case BirdType.Chickadee:
                    return new BirdSizeRange() { Lower = 4.75, Upper = 5.75 };
            }
            throw new InvalidBirdTypeException();
        }
    }

    public enum BirdFood
    {
        Insects,
        Seeds,
        Fruit
    }

    public enum BirdColor
    {
        Black,
        Red,
        Yellow,
        White,
        Tan
    }

   

    public class BirdSizeRange
    {
        public double Lower { get; set; }
        public double Upper { get; set; }
    }

    public enum BirdType
    {
        Cardinal,
        Goldfinch,
        Chickadee
    }
    public class InvalidBirdTypeException : Exception
    {
    }
}