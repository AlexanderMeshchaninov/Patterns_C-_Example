using Decorator_Example.Example2.Abstractions;

namespace Decorator_Example.Example2.Realization
{
    public class BulgarianPizza : PizzaBase
    {
        public BulgarianPizza() : base("Bulgarian Pizza")
        {
        }

        public override int GetCost()
        {
            return 95;
        }
    }
}