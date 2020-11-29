using Decorator.Models;

namespace Decorator
{
    public abstract class CarAccessoriesDecorator : ICar
    {
        private readonly ICar _car;

        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual decimal GetCost()
        {
            return _car.GetCost();
        }
    }
}