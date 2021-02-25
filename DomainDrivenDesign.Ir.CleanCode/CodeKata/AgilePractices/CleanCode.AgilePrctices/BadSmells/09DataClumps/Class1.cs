namespace CleanCode.AgilePractices.BadSmells._09DataClumps
{
    public class Hotel
    {
        public string Lang;
        public string Lat;

        public void SetLangLat(string lang, string lat)
        {
            Lang = lang;
            Lat = lat;
        }
    }

    public class HotelKitchen
    {
        public string Lang;
        public string Lat;

        public void SetLangLat(string lang, string lat)
        {
            Lang = lang;
            Lat = lat;
        }
    }
}