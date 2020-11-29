using Decorator.Models;

namespace Decorator
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car) : base(car)
        {

        }

        public override string GetDescription()
        {
            return $"{ base.GetDescription() } , Basic Accessories Package";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 2000M;
        }
    }
}