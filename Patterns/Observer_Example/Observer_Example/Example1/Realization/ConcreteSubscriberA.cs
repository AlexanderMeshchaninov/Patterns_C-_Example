using System;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example1.Realization
{
    // Конкретные подписчики реагируют на обновления, выпущенные Издателем, к
    // которому они прикреплены.
    public class ConcreteSubscriberA : ISubscriber
    {
        public void GetUpdate(IPublisher publisher)
        {
            if ((publisher as Publisher).State > 3)
            {
                Console.WriteLine("ConcreteSubscriberA: I get an event!!!");
            }
        }
    }
}