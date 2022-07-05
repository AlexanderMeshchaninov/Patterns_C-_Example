using System;
using Mediator_Example.Example2.Abstractions;

namespace Mediator_Example.Example2.Realization
{
    //Конкретный участник 1
    public class SimpleAccount : ParticipantBase
    {
        public SimpleAccount(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a SimpleAccount: ");
            base.Receive(from, message);
        }
    }
}