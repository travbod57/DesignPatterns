namespace AbstractFactory.Models
{
    public class Floor : IPart
    {
        public string Choose()
        {
            return "Floor part has been chosen";
        }
    }
}