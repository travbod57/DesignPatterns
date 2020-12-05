using System;

namespace Mediator.ChatRoom
{
    /// <summary>
    /// Mediator class
    /// </summary>
    public class Participant
    {
        private Chatroom _chatroom;
        private readonly string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public Chatroom Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        // Sends message to all participants
        public void Broadcast(string message)
        {
            _chatroom.Broadcast(_name, message);
        }

        // Receives message from given participant
        public virtual void Receive(string from, string message, bool isPrivate = false)
        {
            Console.WriteLine($"{ _chatroom.Name } : { (isPrivate ? "(private)" : "(broadcast)") } { from } to { Name } : '{ message }'");
        }
    }
}