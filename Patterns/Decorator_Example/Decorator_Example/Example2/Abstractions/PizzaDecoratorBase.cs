namespace Decorator_Example.Example2.Abstractions
{
    public abstract class PizzaDecoratorBase : PizzaBase
    {
        protected PizzaBase _pizzaBase;
        public PizzaDecoratorBase(string name, PizzaBase pizzaBase) 
            : base(name)
        {
            _pizzaBase = pizzaBase;
        }
    }
}