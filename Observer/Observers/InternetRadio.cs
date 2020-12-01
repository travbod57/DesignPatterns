using Observer.Subjects;
using System;

namespace Observer.Observers
{
    public class InternetRadio : IRadio
    {
        public void Output(Broadcaster broadcaster)
        {
            Console.WriteLine($"{ nameof(InternetRadio) } : { broadcaster.Message }");
        }
    }
}