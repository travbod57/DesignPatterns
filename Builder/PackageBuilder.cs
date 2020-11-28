namespace Builder
{
    public class PackageBuilder : IBuilder
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
        public void AddTelevision()
        {
            _package.HasTelevision = true;
        }

        public void AddPhone()
        {
            _package.HasPhone = true;
        }

        public void AddBroadband()
        {
            _package.HasBroadband = true;
        }

        public Package GetPackage()
        {
            // this works because after the reset _package points to a new object on the heap and package is still pointing at the old instance.
            // changing a value on either updates the other before reset is called becasue _package and package has the same reference to the same object
            Package package = _package;

            Reset();

            return package;
        }
    }
}