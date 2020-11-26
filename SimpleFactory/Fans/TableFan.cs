using System;

namespace SimpleFactory.Fans
{
    public class TableFan : IFan
    {
        public TableFan()
        {
            Console.WriteLine("TableFan created");
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