using System;

namespace Mediator.InstantMessenger
{
    public class Alex : StaffMember
    {
        public Alex(Messenger mediator) : base(mediator)
        {

        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Alex gets message: { message }");
        }
    }
}