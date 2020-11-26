namespace FactoryMethod.Models
{
    public class Spider : Car
    {
        public Spider(int doors, string colour, decimal engineSize, string fuel) : base(doors, colour, engineSize, fuel)
        {
                
        }

        public override string ToString()
        {
            return $"Model: Spider, { base.ToString() }";
        }
    }
}