using Observer.Subjects;
using System;

namespace Observer.Observers
{
    public class HiFiRadio : IRadio
    {
        public void Output(Broadcaster broadcaster)
        {
            Console.WriteLine($"{ nameof(HiFiRadio) } : { broadcaster.Message }");
        }
    }
}
