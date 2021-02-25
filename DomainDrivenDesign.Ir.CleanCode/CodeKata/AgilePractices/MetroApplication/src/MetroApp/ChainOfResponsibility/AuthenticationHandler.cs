using System;

namespace MetroApp.ChainOfResponsibility
{
    public class AuthenticationHandler : IHandler<MetroCard>
    {
        private IHandler<MetroCard> _next;

        public IHandler<MetroCard> SetNext(IHandler<MetroCard> handler)
        {
            _next = handler;
            return handler;
        }

        public MetroCard Handle(MetroCard request)
        {
            //TODO check authentication policy
            //if (NotAuthenticate()) throw new Exception();
            return _next.Handle(request);

        }
    }
}