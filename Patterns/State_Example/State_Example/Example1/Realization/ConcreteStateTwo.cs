using System;
using State_Example.Example1.Abstractions;

namespace State_Example.Example1.Realization
{
    public class ConcreteStateTwo : StateBase
    {
        public override void HandleOne()
        {
            Console.WriteLine("ConcreteStateTwo handles requestOne.");
        }

        public override void HandleTwo()
        {
            Console.WriteLine("ConcreteStateTwo handles requestTwo.");
            Console.WriteLine("ConcreteStateTwo wants to change the state of the context.");
            _context.TransitionTo(new ConcreteStateOne());
        }
    }
}