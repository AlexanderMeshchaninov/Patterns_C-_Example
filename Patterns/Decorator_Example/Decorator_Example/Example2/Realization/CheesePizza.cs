using Decorator_Example.Example2.Abstractions;

namespace Decorator_Example.Example2.Realization
{
    public class CheesePizza : PizzaDecoratorBase
    {
        public CheesePizza(PizzaBase pizzaBase) : base(pizzaBase.Name + " [with cheese]", pizzaBase)
        {
        }

        public override int GetCost()
        {
            return _pizzaBase.GetCost() + 20;
        }
    }
}