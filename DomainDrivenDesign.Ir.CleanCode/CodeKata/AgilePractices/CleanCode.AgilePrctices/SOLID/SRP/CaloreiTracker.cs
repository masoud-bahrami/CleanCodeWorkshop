using System;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.SRP
{
    public class CalorieTrackerTests
    {
        [Fact]
        public void Track()
        {
            CalorieTracker calorieTracker = new CalorieTracker();
            var human = new Human("Masoud", "Bahrami", 80, Gender.Male);
            calorieTracker.TrackCalorie(human);
        }
    }

    public class CalorieTracker
    {
        public void TrackCalorie(Human human)
        {
            if (human.Calorie < 20)
            {
                var message = $"جناب آقای {human.FirstName} {human.LastName} : لطفا مراقب باشید. سطح کابری شما بیشتر از {human.Calorie}";
                Write(message);
            }
        }

        private static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Human
    {
        public readonly string FirstName;
        public readonly string LastName;
        private readonly int _age;

        public Gender Gender { get; set; }

        public Human(string firstName, string lastName, int age, Gender gender)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            _age = age;
        }

        public int Calorie { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }
}