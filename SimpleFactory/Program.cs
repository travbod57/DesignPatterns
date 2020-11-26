using System;
using SimpleFactory.Fans;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFanFactory simpleFactory = new FanFactory();

            IFan fan = simpleFactory.CreateFan(FanType.TableFan);
            fan.SwitchOn();

            Console.ReadLine();
        }
    }
}