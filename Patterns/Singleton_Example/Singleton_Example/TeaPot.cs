using System;

namespace Singleton_Example
{
    public sealed class TeaPot
    {
        Singleton _instance = Singleton.GetInstance();

        public TeaPot()
        {
        }

        public void MakeTea()
        {
            Console.WriteLine("I made a tea from" + _instance.SomeBusinessLogic());
        }
    }
}