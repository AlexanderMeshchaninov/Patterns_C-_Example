using System;
using Visitor_Example.Example1.Abstractions;

namespace Visitor_Example.Example1.Realization
{
    public class ConcreteVisitorTwo : IVisitor

    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + "<===ConcreteVisitor A");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentB() + "<===ConcreteVisitor B");
        }
    }
}