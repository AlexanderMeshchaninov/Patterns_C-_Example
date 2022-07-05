using System;
using Mediator_Example.Example1.Abstractions;

namespace Mediator_Example.Example1.Realization
{
    public class ComponentC : ComponentBase
    {
        public void DoC()
        {
            Console.WriteLine("This component does C logic...");
            _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("This component also does D logic...");
            _mediator.Notify(this, "D");
        }
    }
}