using Decorator_Example.Example1.Abstractions;

namespace Decorator_Example.Example1.Realization
{
    public class ConcreteDecoratedComponentB : DecoratorBase
    {
        public ConcreteDecoratedComponentB(ComponentBase componentBase) : base(componentBase)
        {
        }

        public override string Operation()
        {
            return $"Result from concreteDecoratorB + [{base.Operation()}]";
        }
    }
}