using System;

namespace SimpleFactory.Fans
{
    public class ExhaustFan : IFan
    {
        public ExhaustFan()
        {
            Console.WriteLine("ExhaustFan created");
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