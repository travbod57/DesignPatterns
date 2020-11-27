namespace AbstractFactory.Models
{
    public class Roof : IPart
    {
        public string Choose()
        {
            return "Roof part has been chosen";
        }
    }
}