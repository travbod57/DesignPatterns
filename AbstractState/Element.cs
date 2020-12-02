using AbstractState.States;

namespace AbstractState
{
    public abstract class Element
    {
        public decimal MaximumLiquidTemperature { get; }
        public decimal MaximumSolidTemperature { get; }

        public Element(decimal maximumLiquidTemperature, decimal maximumSolidTemperature)
        {
            MaximumLiquidTemperature = maximumLiquidTemperature;
            MaximumSolidTemperature = maximumSolidTemperature;
        }

        public ElementState CurrentState { get; set; }

        public decimal Temperature
        {
            get { return CurrentState.Temperature; }
        }

        public abstract void Heat(decimal amount);

        public abstract void Cool(decimal amount);
    }
}