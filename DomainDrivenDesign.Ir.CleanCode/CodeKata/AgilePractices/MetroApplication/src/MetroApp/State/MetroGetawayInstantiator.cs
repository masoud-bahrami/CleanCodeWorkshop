namespace MetroApp.State
{
    public class MetroGetawayInstantiator
    {
        private static MetroGetawayContext _instance;
        public virtual MetroGetawayContext Instance() => _instance ??= new MetroGetawayContext(new MetroGetawayOpenState());
    }
}