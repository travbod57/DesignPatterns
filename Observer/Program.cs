using Observer.Observers;
using Observer.Subjects;
using System;

namespace Observer
{
    class Program
    {
        /*
         * This structural code demonstrates the Observer pattern in which registered OBSERVERS are notified of a state change on a SUBJECT like a broadcast.
         * 
         * In this pattern, there are many observers (objects) that are observing a particular subject (also an object). 
         * OBSERVERS want to be notified when there is a change made inside the SUBJECT. 
         * So, they register themselves for that SUBJECT. When they lose interest in the SUBJECT, they simply unregister from the SUBJECT.
         * 
         * EXAMPLE: https://www.dofactory.com/net/observer-design-pattern - stocks
         * 
         */

        static void Main(string[] args)
        {
            GhettoBlasterRadio ghettoBlasterRadio = new GhettoBlasterRadio();

            HeartFM heartBroadcaster = new HeartFM();

            heartBroadcaster.Attach(ghettoBlasterRadio);
            heartBroadcaster.Attach(new HiFiRadio());
            heartBroadcaster.Attach(new InternetRadio());

            Console.WriteLine("First Transmission");
            heartBroadcaster.Message = "Good morning listeners!!";

            Console.WriteLine("===================");

            // GhettoBlasterRadio is turned off
            heartBroadcaster.Detach(ghettoBlasterRadio);

            Console.WriteLine("Second Transmission");
            heartBroadcaster.Message = "It's a beautiful morning";

            Console.ReadLine();
        }
    }
}