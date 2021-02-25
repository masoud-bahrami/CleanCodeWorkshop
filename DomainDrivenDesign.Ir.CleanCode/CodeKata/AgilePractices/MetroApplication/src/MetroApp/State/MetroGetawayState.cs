namespace MetroApp.State
{
    public abstract class MetroGetawayState
    {
        protected MetroGetawayContext Context;

        public void SetContext(MetroGetawayContext metroGetawayContext) => Context = metroGetawayContext;

        public abstract void HandleOpen();
        public abstract void HandleClose();
        public abstract State State();
        public abstract MetroGetawayState Clone();
    }
}