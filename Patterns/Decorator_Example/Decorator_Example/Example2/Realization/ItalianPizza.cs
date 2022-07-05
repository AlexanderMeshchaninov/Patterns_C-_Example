using Decorator_Example.Example2.Abstractions;

namespace Decorator_Example.Example2.Realization
{
    public class ItalianPizza : PizzaBase
    {
        public ItalianPizza() : base("Italian Pizza")
        {
        }

        public override int GetCost()
        {
            return 100;
        }
    }
}