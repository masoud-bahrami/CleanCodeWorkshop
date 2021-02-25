namespace MetroApp.State
{
    public class MetroGetawayOpenState : MetroGetawayState
    {
        public override void HandleOpen()
        {
            Context.TransientTo(this.Clone());
        }

        public override void HandleClose()
        {
            Context.TransientTo(new MetroGetawayCloseState());
        }

        public override State State()
        {
            return MetroApp.State.State.Opened;
        }

        public override MetroGetawayState Clone()
        {
            return this.MemberwiseClone() as MetroGetawayOpenState;
        }
    }
}