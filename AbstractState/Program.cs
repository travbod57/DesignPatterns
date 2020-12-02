using System;

namespace AbstractState
{
    class Program
    {
        /*
         * Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
         * 
         * https://www.dofactory.com/net/state-design-pattern
         * 
         * Suggested nuget for a state machine https://github.com/dotnet-state-machine/stateless
         *          
         */

        static void Main(string[] args)
        {
            Water element = new Water();
            element.Heat(100);
            element.Cool(200);

            Console.WriteLine($"The water is { element.CurrentState.State } at a temperature of { element.Temperature } degrees");

            Console.ReadLine();
        }
    }
}
