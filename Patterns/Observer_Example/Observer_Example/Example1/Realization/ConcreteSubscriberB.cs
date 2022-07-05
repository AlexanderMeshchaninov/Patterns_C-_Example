using System;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example1.Realization
{
    public class ConcreteSubscriberB : ISubscriber
    {
        public void GetUpdate(IPublisher publisher)
        {
            if ((publisher as Publisher).State > 15)
            {
                Console.WriteLine("ConcreteSubscriberB: I get an event!!!");
            }
        }
    }
}