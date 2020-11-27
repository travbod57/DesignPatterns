using FactoryMethod.Factories;
using FactoryMethod.Models;

namespace FactoryMethod
{
    public class AssemblyLine
    {
        private readonly CarFactory _carFactory;

        public AssemblyLine(CarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public Car Produce()
        {
            return _carFactory.GetCar();
        }
    }
}