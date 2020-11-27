namespace AbstractFactory.Models
{
    public class Wall : IPart
    {
        public string Choose()
        {
            return "Wall part has been chosen";
        }
    }
}