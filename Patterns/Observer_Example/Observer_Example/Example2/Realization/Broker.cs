using System;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example2.Realization
{
    public class Broker : ISubscriber
    {
        private string Name { get; set; }
        private string Id { get; set; }
        private IPublisher _stock;

        public Broker(string name, string id, IPublisher stock)
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

            if (stockInfo.StockInfo.Rub > 30)
            {
                Console.WriteLine("Брокер {0} продает доллары;  Курс рубля: {1}", Name, stockInfo.StockInfo.Rub);
            }

            Console.WriteLine("Брокер {0} продает доллары;  Курс рубля: {1}", Name, stockInfo.StockInfo.Rub);
        }

        public void StopTrade()
        {
            _stock.Unsubscribe(this);
            _stock = null;
        }
    }
}