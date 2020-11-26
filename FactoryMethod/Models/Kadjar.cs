namespace FactoryMethod.Models
{
    public class Kadjar : Car
    {
        public Kadjar(int doors, string colour, decimal engineSize, string fuel) : base(doors, colour, engineSize, fuel)
        {

        }

        public override string ToString()
        {
            return $"Model: Kadjar, { base.ToString() }";
        }
    }
}