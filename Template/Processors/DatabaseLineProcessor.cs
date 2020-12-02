using System;

namespace Template.Processors
{
    public class DatabaseLineProcessor : LineProcessor
    {
        public override void Process()
        {
            Console.WriteLine("Read lines from database");
        }
    }
}