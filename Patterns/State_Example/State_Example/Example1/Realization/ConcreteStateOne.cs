using System;
using State_Example.Example1.Abstractions;

namespace State_Example.Example1.Realization
{
    public class ConcreteStateOne : StateBase
    {
        public override void HandleOne()
        {
            Console.WriteLine("ConcreteStateOne handles requestOne.");
            Console.WriteLine("ConcreteStateOne wants to change the state of the context.");
            _context.TransitionTo(new ConcreteStateTwo());
        }

        public override void HandleTwo()
        {
            Console.WriteLine("ConcreteStateOne handles requestTwo.");
        }
    }
}