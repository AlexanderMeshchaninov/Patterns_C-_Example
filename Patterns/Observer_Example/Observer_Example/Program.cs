using Observer_Example.Example1.Realization;
using Observer_Example.Example2.Realization;

namespace Observer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Издатель
                Publisher publisher = new Publisher();
            
                //Подписчики
                ConcreteSubscriberA subscriberA = new ConcreteSubscriberA();
                //Подписка на событие
                publisher.Subscribe(subscriberA);

                ConcreteSubscriberB subscriberB = new ConcreteSubscriberB();
                //Подписка на событие
                publisher.Subscribe(subscriberB);
            
                ConcreteSubscriberC subscriberC = new ConcreteSubscriberC();
                //Подписка на событие
                publisher.Subscribe(subscriberC);
            
                publisher.BusinessLogic();
                publisher.BusinessLogic();
            
                publisher.Unsubscribe(subscriberB);
            
                publisher.BusinessLogic();    
            }

            {
                //Издатель
                Stock stock = new Stock();
                
                //Подписчик
                Bank bank = new Bank("Сбербанк", "666", stock);
                
                //Еще подписчик
                Broker broker = new Broker("Василий Пупкин", "545", stock);

                //Имитация бизнес логики (торги)
                stock.Market();
                
                //Прекращают наблюдать за торгами (отписываются от событий)
                broker.StopTrade();
                
                bank.StopTrade();
            }
        }
    }
}