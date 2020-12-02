using System;

namespace SimpleState.States
{
    public class RunState : IDogState
    {
        public RunState()
        {
            State = StatesEnum.Run;
        }

        public void EnterState(Dog context)
        {
            context.HasVision = true;
            context.IsMoving = true;
            context.BreatheHeavily();

            Console.WriteLine("Running");
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
            throw new InvalidStateTransitionException();
        }

        public StatesEnum State { get; }
    }
}