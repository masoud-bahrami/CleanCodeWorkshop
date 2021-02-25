using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.AgilePractices.Smells
{
    public class Birds
    {
        public List<PumageViewModel> Plumages(IList<Bird> birds)
        {
            return birds.Select(b=> new PumageViewModel{ Name=b.Name , Plumage = Plumage (b)}).ToList(); 
        }

        public List<AirSpeedVelocityViewModel> Speeds(IList<Bird> birds)
        {
            return birds.Select(b => new AirSpeedVelocityViewModel { Name = b.Name, AirSpeedVelocity = AirSpeedVelocity(b) }).ToList();

        }

        public string Plumage(Bird bird)
        {
            switch (bird.Type)
            {
                case "EuropeanSwallow":
                    return "Average";
                case "AfricanSwallow":
                    return bird.NumberOfCoconuts > 2 ? "tired" : "average";

                case "NorwegianBlueParrot":
                    return bird.Voltage > 100 ? "scorched" : "beautiful";
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }

        public int AirSpeedVelocity(Bird bird)
        {
            switch (bird.Type)
            {
                case "EuropeanSwallow":
                    return 35;
                case "AfricanSwallow":
                    return 40 - 2 * bird.NumberOfCoconuts;

                case "NorwegianBlueParrot":
                    return bird.IsNailed ? 0 : 10 + (bird.Voltage / 10);
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }

    public class PumageViewModel
    {
        public string Name { get; set; }
        public string Plumage { get; set; }
    }
    public class AirSpeedVelocityViewModel
    {
        public string Name { get; set; }
        public int AirSpeedVelocity { get; set; }
    }

    public class Bird
    {
        public string Name { get; set; }

        public string Type { get; set; }
        public int NumberOfCoconuts { get; set; }
        public int Voltage { get; set; }
        public bool IsNailed { get; set; }
    }
}
