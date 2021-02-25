using Xunit;

namespace CleanCode.AgilePractices.OOP
{
    public class CarTests
    {
        public class CarWasher
        {
            public void Wash(ICarWashable car)
            {
                car.Wash();
            }
        }
        [Fact]
        public void Test()
        {
            new CarWasher().Wash(new Peugeot("405"));
            new CarWasher().Wash(new SunroofPeugeot("405"));
            new CarWasher().Wash(new Peykan());

            Peugeot peugeot = new Peugeot("405");
            Peugeot peugeot1 = new Peugeot("405", 2021);
            peugeot.Start();
            peugeot.TurnTheLights();
            peugeot.TurnOnAirConditioner();
            peugeot.AddGas();
            peugeot.Accelerate();

            peugeot.BeMABegooKeyBayadBenzinBeszanim(50);
            //50 KM
        }

        [Fact]
        public void TestAddGas()
        {
            //Peugeot peugeot = new Peugeot();
            //peugeot.AddGas();
            //Assert.Equal(10,peugeot.FuelAmount);

            //Peugeot peugeot = new SunroofPeugeot();
            //peugeot.AddGas();
            //Assert.Equal(10, peugeot.FuelAmount);

            Peugeot peugeot = new SunroofPeugeot("405");
            peugeot.AddGas();
            Assert.Equal(5, peugeot.FuelAmount);
        }
    }

    public interface ICarWashable
    {
        void Wash();
    }

    public class Peugeot : ICar
    {
        public bool AirConditionerTurnedOn { get; set; } = false;
        public int Speed { get; private set; }
        public int FuelAmount { get; protected set; }
        public string Name { get; set; }
        public int Model { get; set; }

        public Peugeot(string name)
        : this(name, 2020)
        {
        }

        public Peugeot(string name, int model)
        {
            Name = name;
            Model = model;
        }


        public void Start()
        {

        }

        public void TurnTheLights()
        {

        }

        public virtual void AddGas()
        {
            FuelAmount = 10;
        }

        public virtual void AddGas(FuelType type)
        {
            FuelAmount = 10;
        }


        public void Accelerate()
        {
            Speed = 100;
        }

        public void TurnOnAirConditioner()
        {
            AirConditionerTurnedOn = true;
        }

        public void BeMABegooKeyBayadBenzinBeszanim(int i)
        {
            //Tell, Don't Ask

            //AirConditionerTurnedOn;
            //Speed;
            //FuelAmount;
        }

        public void Wash()
        {
            
        }
    }

    public enum FuelType
    {
        CNG,
        Gasoline
    }

    public class SunroofPeugeot : Peugeot
    {
        public override void AddGas()
        {
            FuelAmount = 5;
        }
        public void OpenTheRoof()
        {

        }

        public SunroofPeugeot(string name) : base(name)
        {
        }

        public SunroofPeugeot(string name, int model) : base(name, model)
        {
        }
    }

    public class Peykan : ICar
    {
        public void Start()
        {
            
        }

        public void TurnTheLights()
        {
            throw new System.NotImplementedException();
        }

        public void AddGas()
        {
            throw new System.NotImplementedException();
        }

        public void Wash()
        {
            
        }
    }
}