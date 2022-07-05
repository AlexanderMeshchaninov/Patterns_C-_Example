using Decorator_Example.Example1.Abstractions;

namespace Decorator_Example.Example1.Realization
{
    // Конкретные Декораторы вызывают обёрнутый объект и изменяют его результат
    // некоторым образом.
    public class ConcreteDecoratedComponentA : DecoratorBase
    {
        public ConcreteDecoratedComponentA(ComponentBase componentBase) : base(componentBase)
        {
        }

        // Декораторы могут вызывать родительскую реализацию операции, вместо
        // того, чтобы вызвать обёрнутый объект напрямую. Такой подход упрощает
        // расширение классов декораторов.
        public override string Operation()
        {
            return $"Result from concreteDecoratorA + [{base.Operation()}]";
        }
    }
}