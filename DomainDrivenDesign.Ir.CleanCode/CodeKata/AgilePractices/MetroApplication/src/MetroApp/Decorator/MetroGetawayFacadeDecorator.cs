using MetroApp.ChainOfResponsibility;
using MetroApp.Facade;

namespace MetroApp.Decorator
{
    public class MetroGetawayFacadeDecorator : MetroGetawayFacade
    {
        public override void Process(MetroCard card)
        {
            IHandler<MetroCard> handlers = new AuthenticationHandler()
                .SetNext(new AuthorizationHandler()
                    .SetNext(new MetroGetawayFacadeHandler()));

            handlers.Handle(card);
        }
    }
}