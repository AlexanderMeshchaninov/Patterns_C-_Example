using System;
using Mediator_Example.Example1.Abstractions;

namespace Mediator_Example.Example1.Realization
{
    public class ComponentB : ComponentBase
    {
        public void DoB()
        {
            Console.WriteLine("This component does B logic...");
            _mediator.Notify(this, "B");
        }
    }
}