using System;
using FactoryMethod_Example.Example1;

namespace FactoryMethod_Example
{
    public sealed class Client
    {
        public void ClientCode(AbstractFactory factory)
        {
            Console.WriteLine($"This code from current creator: {factory.Operation()}");
        }
    }
}