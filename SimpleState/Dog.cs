using SimpleState.States;

namespace SimpleState
{
    /// <summary>
    /// This is the context class
    /// </summary>
    public class Dog
    {
        public Dog()
        {
            CurrentState = new SitState();
        }

        public void TransitionToState(IDogState state)
        {
            CurrentState = state;
            CurrentState.EnterState(this);
        }

        public IDogState CurrentState { get; set; }

        public void SlowMetabolism() {

        }

        public void BreatheHeavily()
        {

        }

        public bool HasVision { get; set; }

        public bool IsMoving { get; set; }
    }
}