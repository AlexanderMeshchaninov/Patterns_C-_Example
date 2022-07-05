using System;
using Mediator_Example.Example2.Realization;

namespace Mediator_Example.Example2.Abstractions
{
    //Абстрактный класс для участников чата
    public abstract class ParticipantBase
    {
        public ChatRoom ChatRoom;
        public string Name { get; set; }

        public ParticipantBase(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            ChatRoom.SendMessage(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}