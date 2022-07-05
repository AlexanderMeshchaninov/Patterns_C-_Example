using Decorator_Example.Example1.Abstractions;

namespace Decorator_Example.Example1.Realization
{
    public class ConcreteComponentA : ComponentBase
    {
        public override string Operation()
        {
            return "ConcreteComponent - A";
        }
    }
}