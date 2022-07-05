using System;
using System.Collections.Concurrent;

namespace Singleton_Example
{
    public sealed class Multiton
    {
        private static ConcurrentDictionary<int, Multiton> _instance = new ConcurrentDictionary<int, Multiton>();

        private Multiton(int key)
        {
        }

        public static Multiton GetInstance(int key)
        {
            return _instance.GetOrAdd(key, (x) => new Multiton(x));
        }

        public void BusinessLogic()
        {
            Console.WriteLine("Business logic from multiton object!");
        }
    }
}