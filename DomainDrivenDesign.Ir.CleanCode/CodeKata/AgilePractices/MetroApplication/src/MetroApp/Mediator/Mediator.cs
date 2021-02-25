using MetroApp.Bridge;
using MetroApp.Command;
using MetroApp.Proxy;

namespace MetroApp.Mediator
{
    public class Mediator
    {
        private IResolver _resolver;

        public void Mediat(ChargeMetroCard chargeMetroCard)
        {
            new ChargeMetroCardCommand(chargeMetroCard, new ChargeMetroCardProxy()).Execute();
        }
    }
}