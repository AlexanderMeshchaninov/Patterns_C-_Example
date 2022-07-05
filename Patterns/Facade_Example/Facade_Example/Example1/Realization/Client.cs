using System;

namespace Facade_Example.Example1.Realization
{
    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}