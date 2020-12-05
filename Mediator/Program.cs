using Mediator.ChatRoom;
using Mediator.InstantMessenger;
using System;

namespace Mediator
{
    class Program
    {
        /*
         * 1) It’s an object that encapsulates how objects interact. So it can obviously handle passing on “messages” between objects.
         * 2) It promotes loose coupling by not having objects refer to each other, but instead to the mediator. So they pass the messages to the mediator, who will pass it on to the right person.
         * 
         * The mediator class acts as the middle man so the sender isn't coupled to the receiver
         * Prevents many classes that want to communicate with each other holding references to each other. Instead the mediator handles the communication
         * You have to register classes to notify with the mediator class 
         * 
         * EXAMPLE: https://dotnettutorials.net/lesson/mediator-design-pattern/ - good explanation
         * EXAMPLE: https://dotnetcoretutorials.com/2019/04/30/the-mediator-pattern-in-net-core-part-1-whats-a-mediator/
         * Nuget for mediator pattern https://github.com/jbogard/MediatR
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Instant Messager example\n");

            // Create instant messenger - single notifier per message
            Messenger instantMessenger = new Messenger();

            Alex alex = new Alex(instantMessenger);
            Jamie jamie = new Jamie(instantMessenger);

            instantMessenger.Alex = alex;
            instantMessenger.Jamie = jamie;

            alex.Send("How are you?");
            jamie.Send("Fine, thanks");

            Console.WriteLine("\nChatroom example. Press any key to continue ...\n");
            Console.ReadKey();

            // Create chatroom - single AND multiple notifier per message
            Chatroom chatroom = new Chatroom("Sensible Discussion");

            // Create participants and register them
            Participant iain = new Iain("Iain");
            Participant john = new John("John");
            Participant richard = new Richard("Richard");
            Participant lee = new Lee("Lee");

            chatroom.Register(iain);
            chatroom.Register(john);
            chatroom.Register(richard);
            chatroom.Register(lee);

            // private message participants
            iain.Send("John", "Hi John!");
            john.Send("Iain", "Right back at ya John");

            // send to all in chat room
            richard.Broadcast("Is everyone here yet?");

            Console.ReadLine();
        }
    }
}