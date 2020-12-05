using System;

namespace Mediator.InstantMessenger
{
    public class Jamie : StaffMember
    {
        public Jamie(Messenger mediator) : base(mediator)
        {

        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Jamie gets message: { message }");
        }
    }
}