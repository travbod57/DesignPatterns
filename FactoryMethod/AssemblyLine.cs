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

        public Car Produce(string model)
        {
            return _carFactory.GetCar(model);
        }
    }
}