using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ConstructionFloorFactory : ConstructionFactory
    {
        public override IPart BuildPartShop()
        {
            return new Floor();
        }
        public override IWorker AssignWorker()
        {
            return new FloorWorker();
        }
    }
}