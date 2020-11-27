using System;
using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory
{
    /*
     * Creates object through composition
     * Produces families of objects
     *
     * EXAMPLE: https://medium.com/@sawomirkowalski/design-patterns-abstract-factory-and-its-types-26f3b317a38e
     * EXAMPLE: https://dotnettutorials.net/lesson/abstract-factory-design-pattern-csharp/
     * EXAMPLE: https://www.geeksforgeeks.org/abstract-factory-pattern/
     */

    class Program
    {
        static void Main(string[] args)
        {
            Construction floorConstruction = new Construction(new ConstructionFloorFactory());
            floorConstruction.Start();

            Construction roofConstruction = new Construction(new ConstructionRoofFactory());
            roofConstruction.Start();

            Construction wallConstruction = new Construction(new ConstructionWallFactory());
            wallConstruction.Start();

            Console.ReadLine();
        }
    }
}
