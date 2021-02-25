using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CleanCode.AgilePractices.BadPractices
{
    public class TrainTests
    {
        [Fact]
        public void TestTrain()
        {
            //Abstractioon
            //Encapsulation
            //Information hiding
            //the Law  of Demeter
            // TestTrain
            //objects created by TestTrain
            //Objects sent to it
            //property of its class
            //Train Wriks
            //Tell don't Ask
            //Passenger passenger = new Train().GetPassenger(2);
            Train train = new Train();
            var Coupes = train.GetCoupes();
            Coupe coupe = Coupes.GetCoupe(Guid.NewGuid());
            var passenger = coupe.GetPassenger(2);
        }
    }

    public class Train
    {
        public Coupes GetCoupes()
        {
            return Coupes;
        }

        public Coupes Coupes { get; set; }

        public Passenger GetPassenger(int passengerId)
        {
            return GetCoupes().GetCoupe(Guid.NewGuid()).GetPassenger(passengerId);
        }
    }

    public class Coupes : List<Coupe>
    {
        private List<Coupe> coupes = new List<Coupe>();
        public Coupe GetCoupe(Guid id)
        {
            return coupes.FirstOrDefault(coupe => coupe.Id == id);
        }
    }

    public class Coupe
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public List<Passenger> Passengers;

        public Passenger GetPassenger(int id)
        {
            return Passengers.FirstOrDefault(p => p.Id == id);
        }
    }

    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName;
        public string LastName;
    }
}
