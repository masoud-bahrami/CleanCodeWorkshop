namespace CleanCode.AgilePractices.OOP
{
    public interface ICar : ICarWashable
    {
        void Start();

        void TurnTheLights();

        void AddGas();
    }
}