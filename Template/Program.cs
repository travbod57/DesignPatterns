using System;
using Template.Processors;

namespace Template
{
    class Program
    {
        /*
         * Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
         * Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
         * 
         * Showcaes polymorphc traits at runtime as behaviour changes at runtime through the subcalss overrides
         * 
         */

        static void Main(string[] args)
        {
            LineProcessor fileProcessor = new FileLineProcessor();
            fileProcessor.Process();

            LineProcessor databaseProcessor = new DatabaseLineProcessor();
            databaseProcessor.Process();

            LineProcessor apiProcessor = new ApiLineProcessor();
            apiProcessor.Process();

            // OR

            TextAnalyser analyser = new TextAnalyser(new FileLineProcessor());
            analyser.Run();

            Console.ReadLine();
        }
    }
}
