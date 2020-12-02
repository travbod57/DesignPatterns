using System;

namespace AbstractState.States
{
    public class LiquidState : ElementState
    {
        public LiquidState(Element element, decimal temperature) : base(element, temperature, StatesEnum.Liquid)
        {
            Console.WriteLine($"The element changed to { nameof(LiquidState) }");
        }

        public override void Heat(decimal amount)
        {
            Temperature += amount;

            if (Temperature > Element.MaximumLiquidTemperature)
            {
                Element.CurrentState = new GasState(Element, Temperature);
            }
        }

        public override void Cool(decimal amount)
        {
            Temperature -= amount;

            if (Temperature <= Element.MaximumSolidTemperature)
            {
                Element.CurrentState = new SolidState(Element, Temperature);
            }
        }
    }
}