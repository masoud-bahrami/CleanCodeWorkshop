namespace MetroApp.Template
{
    public interface IChargeCardReaderUi
    {
        string GetBankCardInfo();
        string GetEnteredPassword();
        decimal GetEnteredAmount();
        ChargableMetroCard GetMetroCardInfo();
    }
}