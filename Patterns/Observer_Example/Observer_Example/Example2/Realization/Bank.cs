using System;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example2.Realization
{
    public class Bank : ISubscriber
    {
        private string Name { get; set; }
        private string Id { get; set; }
        private IPublisher _stock;

        public Bank(string name, string id, IPublisher stock)
        {
            Name = name;
            Id = id;
            _stock = stock;
            _stock.Subscribe(this);
        }

        public void GetUpdate(IPublisher publisher)
        {
            Stock stockInfo = publisher as Stock;

            if (stockInfo is null)
            {
                throw new NullReferenceException("NULL");
            }
            
            if (stockInfo.StockInfo.Usd > 30)
            {
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", Name, stockInfo.StockInfo.Usd);
            }

            Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", Name, stockInfo.StockInfo.Usd);
        }

        public void StopTrade()
        {
            _stock.Unsubscribe(this);
            _stock = null;
        }
    }
}