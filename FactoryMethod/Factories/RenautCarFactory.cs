using FactoryMethod.Models;
using System;

namespace FactoryMethod.Factories
{
    public sealed class RenautCarFactory : CarFactory
    {
        protected override Car CreateCar(string model)
        {
            Car car;

            if (model == "Clio")
            {
                car = new Clio(4, "Red", 1.2M, "Petrol");
            }
            else if (model == "Kadjar")
            {
                car = new Kadjar(3, "Green", 1.0M, "Diesel");
            }
            else
            {
                throw new NotSupportedException("No car exists for this model");
            }

            return car;
        }
    }
}