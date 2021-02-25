namespace CleanCode.AgilePractices.BadSmells._08FeatureEnvy
{
    public class ContactInfo
    {
        public string GetStreetName()
        {
            return "Azadi Square";
        }
        public string GetCity()
        {
            return "Tehran";
        }
        public string GetState()
        {
            return "TH";
        }
    }

    public class User
    {
        private ContactInfo _contactInfo;

        private User(ContactInfo contactInfo)
        {
            _contactInfo = contactInfo;
        }

        public string GetFullAddress(ContactInfo info)
        {
            var city = info.GetCity();
            var state = info.GetState();
            var streetName = info.GetStreetName();
            return streetName + ";" + city + ";" + state;
        }
    }
}