namespace CleanCode.AgilePractices.SOLID.ISP.Transaction
{
    public interface IAtmUi
    {
        void RequestToDepositAmount();
        void RequestToWithdrawalAmount();
        void RequestToTransferAmount();
    }

    public  class SpeechUi : IAtmUi
    {
        public void RequestToDepositAmount()
        {
        }

        public void RequestToWithdrawalAmount()
        {
            
        }

        public void RequestToTransferAmount()
        {
            
        }
    }
    public interface ITransaction
    {
        IAtmUi AtmUi { get; set; }
        void Execute();
    }

    public  class DepositTransaction : ITransaction
    {
        public IAtmUi AtmUi { get; set; }

        public void Execute()
        {
            AtmUi.RequestToDepositAmount();
            //...
        }
    }

    public class WithdrawalTransaction : ITransaction
    {
        public IAtmUi AtmUi { get; set; }

        public void Execute()
        {
            AtmUi.RequestToWithdrawalAmount();
            //...
        }
    }

    public class TransferTransaction : ITransaction
    {
        public IAtmUi AtmUi { get; set; }

        public void Execute()
        {
            AtmUi.RequestToTransferAmount();
            //...
        }
    }
}