using MetroApp.State;
using MetroApp.Visitor;

namespace MetroApp.Facade
{
    public class MetroGetawayFacade
    {
        internal MetroGetawayFacade()
        {
            
        }
        public virtual void Process(MetroCard card)
        {
            if (card.IsExpired())
            {
                new MetroGetawayInstantiator().Instance().Close();
                return;
            }

            card.Visit(new MetroCardVisitor());
            new MetroGetawayInstantiator().Instance().Open();
        }
    }
}