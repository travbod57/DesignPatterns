using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
    public class FileReader : IReader
    {
        public List<string> GetLines()
        {
            Console.WriteLine("Read lines from file");

            return new List<string>();
        }
    }
}