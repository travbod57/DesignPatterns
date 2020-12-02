using System;

namespace AbstractState.States
{
    public class SolidState : ElementState
    {
        public SolidState(Element element, decimal temperature) : base(element, temperature, StatesEnum.Solid)
        {
            Console.WriteLine($"The element changed to { nameof(SolidState) }");
        }

        public override void Heat(decimal amount)
        {
            Temperature += amount;

            if (Temperature <= Element.MaximumSolidTemperature)
            {
                Element.CurrentState = new GasState(Element, Temperature);
            }
            else if (Temperature > Element.MaximumSolidTemperature)
            {
                Element.CurrentState = new LiquidState(Element, Temperature);
            }
        }

        public override void Cool(decimal amount)
        {

        }
    }
}