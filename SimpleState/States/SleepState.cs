using System;

namespace SimpleState.States
{
    public class SleepState : IDogState
    {
        public SleepState()
        {
            State = StatesEnum.Sleep;
        }

        public void EnterState(Dog context)
        {
            context.SlowMetabolism();
            context.HasVision = false;
            context.IsMoving = false;
            
            Console.WriteLine("Sleeping");
        }

        public void Run(Dog context)
        {
            throw new InvalidStateTransitionException();
        }
        public void Sit(Dog context)
        {
            context.TransitionToState(new SitState());
        }

        public void Sleep(Dog context)
        {
            context.TransitionToState(new SleepState());
        }

        public StatesEnum State { get; }
    }
}