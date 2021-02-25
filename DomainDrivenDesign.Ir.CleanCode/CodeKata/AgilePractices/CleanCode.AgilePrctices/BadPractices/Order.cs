namespace CleanCode.AgilePractices.BadPractices
{
    public class Order
    {
        public bool IsActive { get; set; }

        public void SetActive(bool isActive)
        {
            IsActive = isActive;
        }

    }
}
