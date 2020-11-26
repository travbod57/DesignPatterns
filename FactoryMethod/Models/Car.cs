namespace FactoryMethod.Models
{
    public abstract class Car
    {
        protected Car(int doors, string colour, decimal engineSize, string fuel)
        {
            Doors = doors;
            Colour = colour;
            EngineSize = engineSize;
            Fuel = fuel;
        }

        public int Doors { get; }
        public string Colour { get; }
        public decimal EngineSize { get; }
        public string Fuel { get; }
        public bool IsVintage { get; set; }

        public override string ToString()
        {
            return $"Doors: { Doors }, Colour: { Colour }, EngineSize: { EngineSize }, Fuel: { Fuel }, IsVintage: { IsVintage }";
        }
    }
}