using Template.Processors;

namespace Template
{
    public class TextAnalyser
    {
        private readonly LineProcessor _lineProcessor;

        public TextAnalyser(LineProcessor lineProcessor)
        {
            _lineProcessor = lineProcessor;
        }

        public void Run()
        {
            _lineProcessor.Process();
        }
    }
}