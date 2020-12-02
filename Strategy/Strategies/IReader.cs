using System.Collections.Generic;

namespace Strategy.Strategies
{
    public interface IReader
    {
        List<string> GetLines();
    }
}