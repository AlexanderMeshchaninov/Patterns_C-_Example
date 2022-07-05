using Decorator_Example.Example1.Abstractions;

namespace Decorator_Example.Example1.Realization
{
    public class ConcreteComponentB : ComponentBase
    {
        public override string Operation()
        {
            return "ConcreteComponent - B";
        }
    }
}