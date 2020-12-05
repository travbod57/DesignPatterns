using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.ChatRoom
{
    public class Chatroom
    {
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public Chatroom(string name)
        {
            Name = $"{ name } Room";
        }

        public string Name { get; }

        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message, isPrivate: true);
            }
        }

        public void Broadcast(string from, string message)
        {
            IEnumerable<Participant> participants = _participants.Where(p => !p.Value.Name.Equals(from, StringComparison.OrdinalIgnoreCase)).Select(p => p.Value);

            foreach (Participant participant in participants)
            {
                participant.Receive(from, message);
            }
        }
    }
}