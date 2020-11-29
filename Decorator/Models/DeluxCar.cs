namespace Decorator.Models
{
    public class DeluxCar : ICar
    {
        public string GetDescription()
        {
            return "Delux Car";
        }

        public decimal GetCost()
        {
            return 750_000M;
        }
    }
}