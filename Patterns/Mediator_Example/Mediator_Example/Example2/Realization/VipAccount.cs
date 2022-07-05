using System;
using Mediator_Example.Example2.Abstractions;

namespace Mediator_Example.Example2.Realization
{
    //Конкретный коллега 2
    public class VipAccount : ParticipantBase
    {
        public VipAccount(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a SimpleAccount: ");
            base.Receive(from, message);
        }
    }
}