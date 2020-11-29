using Decorator.Models;

namespace Decorator
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar aCar)
        : base(aCar)
        {

        }

        public override string GetDescription()
        {
            return $"{ base.GetDescription() }, Advanced Accessories Package";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 10000M;
        }
    }
}