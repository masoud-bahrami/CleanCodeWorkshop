namespace CleanCode.AgilePractices.SOLID.ISP.Door
{
    public interface IDoor
    {
        void Lock();
        void UnLock();
        bool IsOpen();
    }

    public  class WoodenDoor : IDoor
    {
        private bool _isOpened;

        public void Lock()
        {
            _isOpened = false;
        }

        public void UnLock()
        {
            _isOpened = true;
        }

        public bool IsOpen()
        {
            return _isOpened;
        }

    }

    public class TimedDoorAdapter : ITimerClient
    {
        private TimedDoor _timedDoor;
        public void TimeOut(TimedDoor timedDoor)
        {
            _timedDoor = timedDoor;
        }

        public void TimeOut()
        {
            _timedDoor.Lock();
        }
    }

    public class TimedDoor : IDoor, ITimerClient
    {
        private bool _isOpened;

        public void Lock()
        {
            
        }

        public void UnLock()
        {
            
        }

        public bool IsOpen()
        {
            return _isOpened ;
        }

        public void TimeOut()
        {
            UnLock();
        }
    }

    public class Timer
    {
        public void Register(ITimerClient client , int timeout)
        {
            //...
            client.TimeOut();
        }
    }

    public interface ITimerClient
    {
        void TimeOut();
    
    }
}