using System;
using System.Collections.Generic;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example2.Realization
{
    public class Stock : IPublisher
    {
        public StockInfo StockInfo;
        private List<ISubscriber> _subscribers;

        public Stock()
        {
            StockInfo = new StockInfo();
            _subscribers = new List<ISubscriber>();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            Console.WriteLine($"Stock: subscribe");
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Stock: unsubscribe");
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            Console.WriteLine("Stock: Notify broker");

            foreach (var currSubscriber in _subscribers)
            {
                currSubscriber.GetUpdate(this);
            }
        }
        
        public void Market()
        {
            Random rnd = new Random();
            StockInfo.Usd = rnd.Next(20, 40);
            StockInfo.Euro = rnd.Next(30, 50);
            StockInfo.Rub = rnd.Next(40, 60);
            Notify();
        }
    }
}