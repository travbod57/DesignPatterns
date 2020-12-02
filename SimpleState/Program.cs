using SimpleState.States;
using System;

namespace SimpleState
{
    class Program
    {
        /*
         * Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
         * 
         * https://medium.com/net-core/how-to-manage-states-with-state-design-pattern-in-c-d4ca47ec6aa
         * 
         * Suggested nuget for a state machine https://github.com/dotnet-state-machine/stateless
         *          
         */

        static void Main(string[] args)
        {
            // this is the context
            Dog dog = new Dog();

            dog.TransitionToState(new SleepState());
            dog.TransitionToState(new SitState());
            dog.TransitionToState(new RunState());
            dog.TransitionToState(new SitState());
            dog.TransitionToState(new SleepState());

            Console.WriteLine($"The dog is { dog.CurrentState.State }. HasVision: { dog.HasVision }, IsMoving: { dog.IsMoving }");

            Console.ReadLine();
        }
    }
}