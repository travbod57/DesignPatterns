using Decorator.Models;

namespace Decorator
{
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar car) : base(car)
        {

        }

        public override string GetDescription()
        {
            return $"{ base.GetDescription() }, Sports Accessories Package";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 15000M;
        }
    }
}