using System;

namespace SimpleFactory.Fans
{
    public class CeilingFan : IFan
    {
        public CeilingFan()
        {
            Console.WriteLine("CeilingFan created");
        }

        public void SwitchOn()
        {
            Console.WriteLine("On");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Off");
        }
    }
}