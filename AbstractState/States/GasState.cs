using System;

namespace AbstractState.States
{
    public class GasState : ElementState
    {
        public GasState(Element element, decimal temperature) : base(element, temperature, StatesEnum.Gas)
        {
            Console.WriteLine($"The element changed to { nameof(GasState) }");
        }

        public override void Heat(decimal amount)
        {

        }

        public override void Cool(decimal amount)
        {
            Temperature -= amount;

            if (Temperature <= Element.MaximumSolidTemperature)
            {
                Element.CurrentState = new SolidState(Element, Temperature);
            }
            else if(Temperature <= Element.MaximumLiquidTemperature)
            {
                Element.CurrentState = new LiquidState(Element, Temperature);
            }
        }
    }
}