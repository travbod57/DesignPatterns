using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Construction
    {
        private readonly ConstructionFactory _construction;

        public Construction(ConstructionFactory construction)
        {
            _construction = construction;
        }

        public void Start()
        {
            var part = _construction.BuildPartShop();
            Console.WriteLine(part.Choose());

            var worker = _construction.AssignWorker();
            Console.WriteLine(worker.Employ());
        }
    }
}