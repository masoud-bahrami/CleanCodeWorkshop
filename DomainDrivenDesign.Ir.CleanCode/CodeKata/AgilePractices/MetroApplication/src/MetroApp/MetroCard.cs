using MetroApp.Visitor;

namespace MetroApp
{
    public abstract class MetroCard
    {
        public abstract bool IsExpired();
        


        public abstract void Visit(MetroCardVisitor metroCardVisitor);
    }
}