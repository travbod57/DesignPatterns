using AbstractState.States;

namespace AbstractState
{
    /// <summary>
    /// Context class
    /// </summary>
    public class Water : Element
    {
        public Water() : base(maximumLiquidTemperature: 99.9M, maximumSolidTemperature: 0M)
        {
            CurrentState = new LiquidState(this, 20M);
        }

        public override void Heat(decimal amount)
        {
            CurrentState.Heat(amount);
        }

        public override void Cool(decimal amount)
        {
            CurrentState.Cool(amount);
        }
    }
}