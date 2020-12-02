using Strategy.Strategies;
using System;

namespace Strategy
{
    class Program
    {
        /*
         * Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
         * 
         * It’s often used in various frameworks to provide users a way to change the behavior of a class without extending it.
         * 
         */

        static void Main(string[] args)
        {
            LineProcessor processFile = new LineProcessor(new FileReader());
            processFile.Process();

            LineProcessor processDatabase = new LineProcessor(new DatabaseReader());
            processDatabase.Process();

            LineProcessor processAPI = new LineProcessor(new ApiReader());
            processAPI.Process();

            Console.ReadLine();
        }
    }
}
