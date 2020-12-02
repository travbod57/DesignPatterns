using Strategy.Strategies;

namespace Strategy
{
    public class LineProcessor
    {
        private readonly IReader _reader;

        public LineProcessor(IReader reader)
        {
            _reader = reader;
        }

        public void Process()
        {
            _reader.GetLines();
        }
    }
}