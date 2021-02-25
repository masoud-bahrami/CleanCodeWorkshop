using MetroApp.Facade;

namespace MetroApp.ChainOfResponsibility
{
    public class MetroGetawayFacadeHandler : IHandler<MetroCard>
    {
        public IHandler<MetroCard> SetNext(IHandler<MetroCard> handler)
        {
            return this;
        }

        public MetroCard Handle(MetroCard request)
        {
            new MetroGetawayFacade().Process(request);

            return request;
        }
    }
}