using System;
using Adapter_Example.Example2.Abstractions;

namespace Adapter_Example.Example2.Realization
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по песку...");
        }
    }
}