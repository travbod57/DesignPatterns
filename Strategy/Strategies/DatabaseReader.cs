using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
    public class DatabaseReader : IReader
    {
        public List<string> GetLines()
        {
            Console.WriteLine("Read lines from database");

            return new List<string>();
        }
    }
}