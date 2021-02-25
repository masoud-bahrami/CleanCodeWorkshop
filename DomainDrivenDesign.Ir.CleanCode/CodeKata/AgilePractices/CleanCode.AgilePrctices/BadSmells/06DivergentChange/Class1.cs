namespace CleanCode.AgilePractices.BadSmells._06DivergentChange
{
    public class Product
    {
        private readonly string type;

        public Product(string type)
        {
            this.type = type;
        }

        public int GetBasePrice()
        {
            switch (this.type)
            {
                case "food":
                    return 10;
                case "drinks":
                    return 7;
                case "books":
                    return 3;
                default:
                    return 0;
            }
        }

        public int GetTaxPercent()
        {
            switch (this.type)
            {
                case "food":
                case "drinks":
                    return 24;
                case "books":
                    return 8;
                default:
                    return 0;
            }
        }

        public string GetProductCategory()
        {
            switch (this.type)
            {
                case "food":
                case "drinks":
                    return "Food and Beverages";
                case "books":
                    return "Education";
                default:
                    return "-";
            }
        }
    }
}