using System;
using Decorator_Example.Example1.Abstractions;

namespace Decorator_Example.Example1.Realization
{
    public sealed class Client
    {
        public void ClientCode(ComponentBase componentBase)
        {
            Console.WriteLine($"RESULT: {componentBase.Operation()}");
        }
    }
}