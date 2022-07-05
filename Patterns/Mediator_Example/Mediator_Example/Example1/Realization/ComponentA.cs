using System;
using Mediator_Example.Example1.Abstractions;

namespace Mediator_Example.Example1.Realization
{
    // Конкретные Компоненты реализуют различную функциональность. Они не
    // зависят от других компонентов. Они также не зависят от каких-либо
    // конкретных классов посредников.
    public class ComponentA : ComponentBase
    {
        public void DoA()
        {
            Console.WriteLine("This component does A logic...");
            _mediator.Notify(this, "A");
        }
    }
}