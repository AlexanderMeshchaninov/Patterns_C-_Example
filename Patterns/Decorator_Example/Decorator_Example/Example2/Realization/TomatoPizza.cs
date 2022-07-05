using Decorator_Example.Example2.Abstractions;

namespace Decorator_Example.Example2.Realization
{
    public class TomatoPizza : PizzaDecoratorBase
    {
        public TomatoPizza(PizzaBase pizzaBase) : base(pizzaBase.Name + " [with tomatos]", pizzaBase)
        {
        }

        public override int GetCost()
        {
            return _pizzaBase.GetCost() + 15;
        }
    }
}