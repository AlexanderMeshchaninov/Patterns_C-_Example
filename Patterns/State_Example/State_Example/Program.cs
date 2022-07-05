using System;
using State_Example.Example1.Realization;
using State_Example.Example2.Realization;

namespace State_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Клиентский код.
                Context context = new Context(new ConcreteStateOne());
                context.RequestOne();
                context.RequestTwo();
            }

            {
                Water water = new Water(new LiquidWaterState());
                water.Heat();
                water.Frost();
                water.Frost();
            }
        }
    }
}