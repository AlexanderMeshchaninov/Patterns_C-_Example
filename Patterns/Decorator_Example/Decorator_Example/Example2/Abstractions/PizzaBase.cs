namespace Decorator_Example.Example2.Abstractions
{
    public abstract class PizzaBase
    {
        public string Name { get; protected set; }

        public PizzaBase(string name)
        {
            Name = name;
            
        }

        public abstract int GetCost();
    }
}