namespace Mediator.InstantMessenger
{
    public abstract class StaffMember
    {
        protected Messenger mediator;

        // Constructor

        public StaffMember(Messenger mediator)
        {
            this.mediator = mediator;
        }
    }
}