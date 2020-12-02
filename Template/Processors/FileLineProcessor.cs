using System;

namespace Template.Processors
{
    public class FileLineProcessor : LineProcessor
    {
        public override void Process()
        {
            Console.WriteLine("Read lines from file");
        }
    }
}