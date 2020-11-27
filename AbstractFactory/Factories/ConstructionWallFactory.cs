using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ConstructionWallFactory : ConstructionFactory
    {
        public override IPart BuildPartShop()
        {
            return new Wall();
        }
        public override IWorker AssignWorker()
        {
            return new WallWorker();
        }
    }
}