using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public abstract class ConstructionFactory
    {
        public abstract IPart BuildPartShop();
        public abstract IWorker AssignWorker();
    }
}