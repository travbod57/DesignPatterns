using System;
using FactoryMethod.Factories;
using FactoryMethod.Models;

namespace FactoryMethod
{
    /*
     * Factory methods can be recognized by creation methods, which create objects from concrete classes, but return them as objects of abstract type or interface.
     * EXAMPLE: https://refactoring.guru/design-patterns/factory-method/csharp/example#:~:text=Factory%20method%20is%20a%20creational,constructor%20call%20(%20new%20operator).
     */

    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLine assemblyLine1 = new AssemblyLine(new RenautCarFactory());

            Car renault = assemblyLine1.Produce("Clio");
            Console.WriteLine(renault.ToString());

            AssemblyLine assemblyLine2 = new AssemblyLine(new FerrariCarFactory());

            Car ferrari = assemblyLine2.Produce("Spider");
            Console.WriteLine(ferrari.ToString());

            Console.ReadLine();
        }
    }
}
