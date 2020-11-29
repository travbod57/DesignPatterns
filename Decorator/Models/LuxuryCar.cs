namespace Decorator.Models
{
    public class LuxuryCar : ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public decimal GetCost()
        {
            return 1_000_000M;
        }
    }
}