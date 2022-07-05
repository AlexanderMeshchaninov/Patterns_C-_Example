using System;
using Decorator_Example.Example1.Realization;
using Decorator_Example.Example2.Abstractions;
using Decorator_Example.Example2.Realization;

namespace Decorator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Client client = new Client();

                ConcreteComponentA componentA = new ConcreteComponentA();
                ConcreteComponentB componentB = new ConcreteComponentB();
                client.ClientCode(componentA);
                client.ClientCode(componentB);
                
                //---->Decorated components
                ConcreteDecoratedComponentA decoratedComponentA = new ConcreteDecoratedComponentA(componentB);
                ConcreteDecoratedComponentB decoratedComponentB = new ConcreteDecoratedComponentB(componentA);
                Console.WriteLine("Client: Now I've got a decorated component:");
                client.ClientCode(decoratedComponentA);
                client.ClientCode(decoratedComponentB);
            }

            {
                PizzaBase italianPizza = new ItalianPizza();
                
                italianPizza = new TomatoPizza(italianPizza); // итальянская пицца с томатами (добавляем динамически)
                Console.WriteLine("Название: {0}", italianPizza.Name);
                Console.WriteLine("Цена: {0}", italianPizza.GetCost());
 
                PizzaBase pizza2 = new ItalianPizza();
                
                pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
                Console.WriteLine("Название: {0}", pizza2.Name);
                Console.WriteLine("Цена: {0}", pizza2.GetCost());
 
                PizzaBase pizza3 = new BulgarianPizza();
                
                pizza3 = new TomatoPizza(pizza3);
                pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
                Console.WriteLine("Название: {0}", pizza3.Name);
                Console.WriteLine("Цена: {0}", pizza3.GetCost());
            }
        }
    }
}