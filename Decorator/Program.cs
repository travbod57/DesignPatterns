using Decorator.Models;
using System;

namespace Decorator
{
    class Program
    {
        /*
         * The decorator pattern is used to extend or alter the functionality of objects at run-time by wrapping them in an object of a decorator class. 
         * This provides a flexible alternative to using inheritance to modify behaviour.
         * 
         * The decorator implements the same interface as the type it decorates, each method calling the decorated type's members, adding functionality as needed.
         * 
         * EXAMPLE: https://www.c-sharpcorner.com/UploadFile/damubetha/decorator-pattern-in-csharp/
         * EXAMPLE: https://www.c-sharpcorner.com/UploadFile/20c06b/design-patterns-decorator/ - weapon example
         * EXAMPLE: https://www.dotnettricks.com/learn/designpatterns/decorator-design-pattern-dotnet - special offeres example
         */

        static void Main(string[] args)
        {
            ICar car = new DeluxCar();
            Console.WriteLine($"Description: { car.GetDescription() }, Cost: { car.GetCost().ToString("C") }");

            // give the car advanced accessories
            car = new AdvancedAccessories(car);
            Console.WriteLine($"Description: { car.GetDescription() }, Cost: { car.GetCost().ToString("C") }");

            // add sports accessories
            car = new SportsAccessories(car);
            Console.WriteLine($"Description: { car.GetDescription() }, Cost: { car.GetCost().ToString("C") }");

            Console.ReadLine();
        }
    }
}