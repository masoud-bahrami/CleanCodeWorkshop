namespace MetroApp.State
{
    public class MetroGetawayContext
    {
        private MetroGetawayState _state;
        
        public MetroGetawayContext(MetroGetawayState state)
        {
            TransientTo(state);
        }

        internal void TransientTo(MetroGetawayState state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public bool IsOpen()
        {
            return _state.State() == State.Opened;
        }

        public void Open()
        {
            _state.HandleOpen();
        }

        public void Close()
        {
            _state.HandleClose();
        }
    }
}