using FactoryMethod.Models;
using System;

namespace FactoryMethod.Factories
{
    public sealed class FerrariCarFactory : CarFactory
    {
        protected override Car CreateCar(string model)
        {
            Car car;

            if (model == "Roma")
            {
                car = new Roma(3, "Yellow", 2.2M, "Petrol");
            }
            else if (model == "Spider")
            {
                car = new Spider(3, "Red", 3.0M, "Petrol");
            }
            else
            {
                throw new NotSupportedException("No car exists for this model");
            }

            return car;
        }
    }
}