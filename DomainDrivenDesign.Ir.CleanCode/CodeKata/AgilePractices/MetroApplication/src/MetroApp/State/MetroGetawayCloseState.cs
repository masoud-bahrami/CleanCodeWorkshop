namespace MetroApp.State
{
    public class MetroGetawayCloseState : MetroGetawayState
    {
        public override void HandleOpen()
        {
            if (Context.IsOpen())
                return;

            Context.TransientTo(new MetroGetawayOpenState());
        }

        public override void HandleClose()
        {
            if (!Context.IsOpen())
                return;

            Context.TransientTo(this.Clone());
        }

        public override State State()
        {
            return MetroApp.State.State.Closed;
        }

        public override MetroGetawayState Clone()
        {
            return this.MemberwiseClone() as MetroGetawayCloseState;
        }
    }
}