using System;

namespace StandardBuilder
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
     * The Director is only responsible for executing the building steps in a
     * particular sequence. It is helpful when producing products according to a
     * specific order or configuration. Strictly speaking, the Director class is
     * optional, since the client can control builders directly.
     */

    class Program
    {
        static void Main(string[] args)
        {
            PackageBuilder builder = new PackageBuilder();
            PackageDirector director = new PackageDirector(builder);

            director.BuildMegaBundle();
            Package megaBundle = builder.GetPackage();

            Console.WriteLine($"Mega Bundle - Television: { megaBundle.HasTelevision }, Phone: { megaBundle.HasPhone }, Broadband: { megaBundle.HasBroadband }");

            director.BuildInternetPackage();
            Package internetBundle = builder.GetPackage();

            Console.WriteLine($"Internet Package - Television: { internetBundle.HasTelevision }, Phone: { internetBundle.HasPhone }, Broadband: { internetBundle.HasBroadband }");

            Console.ReadLine();
        }
    }
}