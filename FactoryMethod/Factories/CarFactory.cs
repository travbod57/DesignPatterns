using FactoryMethod.Models;

namespace FactoryMethod.Factories
{
    /// <summary>
    /// The CREATOR class
    /// </summary>
    public abstract class CarFactory
    {
        protected abstract Car CreateCar(string model);

        public Car GetCar(string model)
        {
            var car = CreateCar(model);

            // optional business logic can go here

            if (model == "Clio" && car.Colour == "Red")
            {
                car.IsVintage = true;
            }

            return car;
        }
    }
}