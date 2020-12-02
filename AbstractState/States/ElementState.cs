namespace AbstractState.States
{
    public abstract class ElementState
    {
        public ElementState(Element element, decimal temperature, StatesEnum state)
        {
            Element = element;
            Temperature = temperature;
            State = state;
        }

        public StatesEnum State { get; }

        protected Element Element { get; }

        public decimal Temperature { get; protected set; }

        public abstract void Heat(decimal amount);
        public abstract void Cool(decimal amount);
    }
}