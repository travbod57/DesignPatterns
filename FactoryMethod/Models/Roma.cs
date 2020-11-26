namespace FactoryMethod.Models
{
    public class Roma : Car
    {
        public Roma(int doors, string colour, decimal engineSize, string fuel) : base(doors, colour, engineSize, fuel)
        {
                
        }

        public override string ToString()
        {
            return $"Model: Roma, { base.ToString() }";
        }
    }
}