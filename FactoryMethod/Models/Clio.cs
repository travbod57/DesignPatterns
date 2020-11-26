namespace FactoryMethod.Models
{
    public class Clio : Car
    {
        public Clio(int doors, string colour, decimal engineSize, string fuel) : base(doors, colour, engineSize, fuel)
        {
                
        }

        public override string ToString()
        {
            return $"Model: Clio, { base.ToString() }";
        }
    }
}