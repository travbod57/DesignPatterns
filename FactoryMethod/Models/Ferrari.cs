namespace FactoryMethod.Models
{
    public class Ferrari : Car
    {
        public Ferrari(int doors, string colour, decimal engineSize, string fuel) : base(doors, colour, engineSize, fuel)
        {
                
        }

        public override string ToString()
        {
            return $"Model: Ferrari, { base.ToString() }";
        }
    }
}