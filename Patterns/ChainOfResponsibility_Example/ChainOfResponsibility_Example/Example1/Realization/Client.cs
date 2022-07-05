using System;
using System.Collections.Generic;
using ChainOfResponsibility_Example.Example1.Abstractions;

namespace ChainOfResponsibility_Example.Example1.Realization
{
    public sealed class Client
    {
        public static void ClientCode(HandlerBase handler)
        {
            var foodList = new List<string>()
            {
                "banana",
                "bone",
                "seeds",
                "cup of tea",
                "milk",
                "coffee"
            };

            foreach (var food in foodList)
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result is not null)
                {
                    Console.Write($"{result}");
                }
                else
                {
                    Console.WriteLine($"{food} was left untouched.");
                }
            }
        }
    }
}