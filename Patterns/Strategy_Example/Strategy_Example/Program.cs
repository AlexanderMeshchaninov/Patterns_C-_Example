using System;
using Strategy_Example.Example1.Realization;
using Strategy_Example.Example2.Realization;

namespace Strategy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Клиентский код выбирает конкретную стратегию и передаёт её в
                // контекст. Клиент должен знать о различиях между стратегиями,
                // чтобы сделать правильный выбор.
                Context context = new Context();
                
                context.SetStrategy(new GoByCar());
                context.DoSomeBusinessLogic();
                
                context.SetStrategy(new GoByFoot());
                context.DoSomeBusinessLogic();
                
                context.SetStrategy(new GoByCityTransport());
                context.DoSomeBusinessLogic();
            }

            {
                Car auto = new Car(4, "Kia Sportage");
                auto.SetStrategy(new ElectricCar());
                auto.Move();
                
                auto.SetStrategy(new PetroleumCar());
                auto.Move();
                
                auto.SetStrategy(new FlyingCar());
                auto.Move();
            }
        }
    }
}