using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
    public class ApiReader : IReader
    {
        public List<string> GetLines()
        {
            Console.WriteLine("Read lines from API");

            return new List<string>();
        }
    }
}
