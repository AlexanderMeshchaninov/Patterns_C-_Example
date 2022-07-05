using System;

namespace Singleton_Example
{
    public sealed class Cup
    {
        Singleton _instance = Singleton.GetInstance();

        public Cup()
        {
        }

        public void DrinkWater()
        {
            Console.WriteLine("I drink water from" + _instance.SomeBusinessLogic());
        }
    }
}