using FactoryMethod.Models;

namespace FactoryMethod.Factories
{
    /// <summary>
    /// The CREATOR class
    /// </summary>
    public abstract class CarFactory
    {
        protected abstract Car CreateCar();

        public Car GetCar()
        {
            var car = CreateCar();

            // optional business logic can go here

            if (car.Colour == "Red")
            {
                car.IsVintage = true;
            }

            return car;
        }
    }
}