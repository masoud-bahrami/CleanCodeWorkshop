using Xunit;

namespace CleanCode.AgilePractices.SOLID.ISP.Door
{
    public class DoorTests
    {
        [Fact]
        public void TestOpenTheWoodenDoor()
        {
            IDoor woodenDoor = new WoodenDoor();
            woodenDoor.UnLock();
            Assert.True(woodenDoor.IsOpen());
        }

        [Fact]
        public void TimedDoor_ItIsOpenTooMuch_AlarmWillSound()
        {
            IDoor timedDoor = new TimedDoor();
            timedDoor.UnLock();

            Timer timer = new Timer();
            ITimerClient client = new TimedDoor();
            timer.Register(client , 3);
        }
    }

}
