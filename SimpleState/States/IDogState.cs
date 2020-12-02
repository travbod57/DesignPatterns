namespace SimpleState.States
{
    public interface IDogState
    {
        public void EnterState(Dog context);
        public void Run(Dog context);
        public void Sit(Dog context);
        public void Sleep(Dog context);
        public StatesEnum State { get; }
    }
}