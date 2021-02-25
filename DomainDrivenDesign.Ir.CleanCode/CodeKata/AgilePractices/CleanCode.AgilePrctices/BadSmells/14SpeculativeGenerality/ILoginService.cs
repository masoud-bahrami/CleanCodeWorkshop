namespace CleanCode.AgilePractices.BadSmells._14SpeculativeGenerality
{
    public interface ILoginService
    {
        void Login(string userName, string password);
    }
    public class LoginByUserAndPassword : ILoginService
    {
        public void Login(string userName, string password)
        {
            //implementation
        }
    }

    public class LoginByGoogle : ILoginService
    {
        public void Login(string userName, string password)
        {
            
        }
    }

    public class LoginByFaceBook : ILoginService
    {
        public void Login(string userName, string password)
        {

        }
    }
}