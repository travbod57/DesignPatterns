namespace Builder
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class PackageDirector
    {
        private readonly IBuilder _builder;

        public PackageDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildMegaBundle()
        {
            // this could be fluent here
            _builder.AddTelevision();
            _builder.AddPhone();
            _builder.AddBroadband();
        }

        public void BuildInternetPackage()
        {
            // this could be fluent her
            _builder.AddPhone();
            _builder.AddBroadband();
        }
    }
}