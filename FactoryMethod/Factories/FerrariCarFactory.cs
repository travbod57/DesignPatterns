using FactoryMethod.Models;

namespace FactoryMethod.Factories
{
    public sealed class FerrariCarFactory : CarFactory
    {
        protected override Car CreateCar()
        {
            return new Ferrari(3, "Yellow", 2.2M, "Petrol");
        }
    }
}