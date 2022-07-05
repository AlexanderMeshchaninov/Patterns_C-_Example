using System;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example1.Realization
{
    public class ConcreteSubscriberC : ISubscriber
    {
        public void GetUpdate(IPublisher publisher)
        {
            if ((publisher as Publisher).State > 10)
            {
                Console.WriteLine("ConcreteSubscriberA: I get an event!!!");
            }
        }
    }
}