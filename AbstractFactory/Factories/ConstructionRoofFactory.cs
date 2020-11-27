using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ConstructionRoofFactory : ConstructionFactory
    {
        public override IPart BuildPartShop()
        {
            return new Roof();
        }
        public override IWorker AssignWorker()
        {
            return new RoofWorker();
        }
    }
}