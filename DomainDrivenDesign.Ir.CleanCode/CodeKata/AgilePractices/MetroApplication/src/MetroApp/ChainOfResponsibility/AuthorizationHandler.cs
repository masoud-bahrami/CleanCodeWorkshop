namespace MetroApp.ChainOfResponsibility
{
    public class AuthorizationHandler : IHandler<MetroCard>
    {
        private IHandler<MetroCard> _next;

        public IHandler<MetroCard> SetNext(IHandler<MetroCard> handler)
        {
            _next = handler;
            return handler;
        }

        public MetroCard Handle(MetroCard request)
        {
            //Check authorization policy
            return _next.Handle(request);
        }
    }
}