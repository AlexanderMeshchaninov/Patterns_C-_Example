using System;
using System.Collections.Generic;
using Mediator_Example.Example2.Abstractions;

namespace Mediator_Example.Example2.Realization
{
    //Реализация медиатора (посредника)
    public sealed class ChatRoom : IChatroom
    {
        private Dictionary<string, ParticipantBase> _participants;

        public ChatRoom()
        {
            _participants = new Dictionary<string, ParticipantBase>();
        }

        public void Register(ParticipantBase participant)
        {
            if (!_participants.ContainsKey(participant.Name))
            {
                _participants.Add(participant.Name, participant);
            }

            participant.ChatRoom = this;
        }

        public void SendMessage(string from, string to, string message)
        {
            ParticipantBase pto = _participants[to];

            if (pto is not null)
            {
                pto.Receive(from, message);
            }
        }
    }
}