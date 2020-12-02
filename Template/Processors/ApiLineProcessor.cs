using System;

namespace Template.Processors
{
    public class ApiLineProcessor : LineProcessor
    {
        public override void Process()
        {
            Console.WriteLine("Read lines from API");
        }
    }
}