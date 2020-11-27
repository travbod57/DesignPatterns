namespace FactoryMethod.Models
{
    public class Renaut : Car
    {
        public Renaut(int doors, string colour, decimal engineSize, string fuel) : base(doors, colour, engineSize, fuel)
        {
                
        }

        public override string ToString()
        {
            return $"Model: Renaut, { base.ToString() }";
        }
    }
}