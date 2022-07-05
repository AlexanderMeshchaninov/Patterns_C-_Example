using System;
using Mediator_Example.Example1.Abstractions;

namespace Mediator_Example.Example1.Realization
{
    // Конкретные Посредники реализуют совместное поведение, координируя
    // отдельные компоненты.
    public class ConcreteMediator : IMediator
    {
        private ComponentA _componentA;
        private ComponentB _componentB;
        private ComponentC _componentC;

        public ConcreteMediator(
            ComponentA componentA, 
            ComponentB componentB, 
            ComponentC componentC)
        {
            _componentA = componentA;
            _componentA.SetMediator(this);
            
            _componentB = componentB;
            _componentB.SetMediator(this);
            
            _componentC = componentC;
            _componentC.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            //Здесь стоит выстроить цепочку кто к кому обращается иначе можно получить зацикливание!!!
            if (ev is "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                _componentB.DoB();
            }
            if (ev is "B")
            {
                Console.WriteLine("Mediator reacts on B and triggers following operations:");
                _componentC.DoD();
            }
            if (ev is "C" or "D")
            {
                Console.WriteLine("Mediator reacts on C and triggers following operations:");
            }
        }
    }
}