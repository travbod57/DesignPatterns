using System;

namespace SimpleState.States
{
    public class SitState : IDogState
    {
        public SitState()
        {
            State = StatesEnum.Sit;
        }

        public void EnterState(Dog context)
        {
            context.HasVision = true;
            context.IsMoving = false;

            Console.WriteLine("Sitting");
        }

        public void Run(Dog context)
        {
            context.TransitionToState(new RunState());
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