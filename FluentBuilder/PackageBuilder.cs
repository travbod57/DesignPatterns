namespace FluentBuilder
{
    public class PackageBuilder
    {
        private Package _package;

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public PackageBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _package = new Package();
        }

        // All production steps work with the same product instance.
        public PackageBuilder AddTelevision()
        {
            _package.HasTelevision = true;

            return this;
        }

        public PackageBuilder AddPhone()
        {
            _package.HasPhone = true;

            return this;
        }

        public PackageBuilder AddBroadband()
        {
            _package.HasBroadband = true;

            return this;
        }

        public Package Build() => _package;
    }
}