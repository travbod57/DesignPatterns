using System;

namespace FluentBuilder
{
    /*
     *
     * The Builder design pattern is a creational design pattern that lets us create an object one step at a time.
     * It is quite common to use this pattern when creating a complex object. By using this pattern, we can create different parts of an object, step by step,
     * and then connect all the parts together.
     *
     * Without this pattern, we can end up with a large constructor to provide all the required parameters for constructing our object.
     * That could lead to quite unreadable and hardly maintainable code. Furthermore, a constructor with lots of parameters has a downside to it.
     * We won’t need to use all the parameters, all the time.
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            PackageBuilder packageBuilder1 = new PackageBuilder();
            Package megaBundle = packageBuilder1.AddBroadband()
                                                .AddTelevision()
                                                .AddPhone()
                                                .Build();

            Console.WriteLine($"Mega Bundle - Television: { megaBundle.HasTelevision }, Phone: { megaBundle.HasPhone }, Broadband: { megaBundle.HasBroadband }");

            PackageBuilder packageBuilder2 = new PackageBuilder();
            Package internetBundle = packageBuilder2.AddBroadband()
                                                    .AddPhone()
                                                    .Build();

            Console.WriteLine($"Internet Package - Television: { internetBundle.HasTelevision }, Phone: { internetBundle.HasPhone }, Broadband: { internetBundle.HasBroadband }");

            Console.ReadLine();
        }
    }
}
