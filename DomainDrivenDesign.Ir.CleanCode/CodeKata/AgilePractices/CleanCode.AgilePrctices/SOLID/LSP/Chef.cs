namespace CleanCode.AgilePractices.SOLID.LSP
{
    public class Chef
    {
        public void CockRice(IranRiceMaker iranRiceMaker)
        {
            iranRiceMaker.Wash();
            iranRiceMaker.AddWaterToThePut(couple: 3);
            iranRiceMaker.AddRiceToThePot(couple: 2);
            iranRiceMaker.AddSaltToThePot(couple: 3);
            //TODO after 5 minutes
            iranRiceMaker.Strain();
            iranRiceMaker.ServeTheRice();
        }
    }


    public class IranRiceMaker
    {
        public void Wash()
        {

        }

        public void AddWaterToThePut(int couple)
        {
        }

        public void AddRiceToThePot(int couple)
        {
        }

        public void AddSaltToThePot(int couple)
        {
        }

        public void Strain()
        {
        }

        public void ServeTheRice()
        {
        }

    }
}