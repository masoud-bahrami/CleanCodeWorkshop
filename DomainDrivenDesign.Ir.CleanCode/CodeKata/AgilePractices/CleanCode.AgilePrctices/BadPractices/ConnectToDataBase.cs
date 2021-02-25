using System;

namespace CleanCode.AgilePractices.BadPractices
{
    public class ConnectToDataBase
    {
        private readonly ILogger _logger;

        public ConnectToDataBase(ILogger logger)
        {
            _logger = logger;
        }

        public void Connect()
        {
            try
            {
                new MongoDriverWrapper(new MongoDriver()).Connect("Admin", "Administrator", "localhost", 25371);
            }
            catch (DriverConnectionException e)
            {
                _logger.LogeError("User or password is wrong", e);
            }
        }
    }

    public class NetworkConnectionException : Exception { }
    public class ConnectionTimeoutException : Exception
    {
    }

    public class UserOrPasswordIsWrong : Exception
    {
    }

    public class DriverConnectionException : Exception
    {
        public DriverConnectionException(string message, Exception exception)
        : base(message, exception)
        {

        }
    }
    public class MongoDriverWrapper
    {
        private MongoDriver _mongoDriver;

        public MongoDriverWrapper(MongoDriver mongoDriver)
        {
            _mongoDriver = mongoDriver;
        }

        public void Connect(string admin, string administrator, string localhost, int port)
        {
            try
            {
                _mongoDriver.Connect("Admin", "Administrator", "localhost", 25371);
            }
            catch (UserOrPasswordIsWrong e)
            {
                throw new DriverConnectionException("User or password is wrong", e);
            }
            catch (NetworkConnectionException e)
            {
                throw new DriverConnectionException("Network connection exception", e);
            }
            catch (ConnectionTimeoutException e)
            {
                //5s wait 
                throw new DriverConnectionException("connection is timed out", e);
            }
        }
    }

    public class MongoDriver
    {
        public void Connect(string admin, string administrator, string localhost, int port)
        {
            //TODO
        }
    }
}