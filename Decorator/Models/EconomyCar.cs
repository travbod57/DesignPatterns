namespace Decorator.Models
{
    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public decimal GetCost()
        {
            return 450_000M;
        }
    }
}