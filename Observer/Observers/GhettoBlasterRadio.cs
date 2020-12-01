using Observer.Subjects;
using System;

namespace Observer.Observers
{
    public class GhettoBlasterRadio : IRadio
    {
        public void Output(Broadcaster broadcaster)
        {
            Console.WriteLine($"{ nameof(GhettoBlasterRadio) } : { broadcaster.Message }");
        }
    }
}