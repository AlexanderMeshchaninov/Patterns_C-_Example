using System;
using System.Collections.Generic;
using System.Threading;
using Observer_Example.Example1.Abstractions;

namespace Observer_Example.Example1.Realization
{
    // Издатель владеет некоторым важным состоянием и оповещает наблюдателей о
    // его изменениях.
    public class Publisher : IPublisher
    {
        // Для удобства в этой переменной хранится состояние Издателя,
        // необходимое всем подписчикам.
        public int State { get; set; } = -0;

        // Список подписчиков. В реальной жизни список подписчиков может
        // храниться в более подробном виде (классифицируется по типу события и
        // т.д.)
        private List<ISubscriber> _subscribers;

        public Publisher()
        {
            _subscribers = new List<ISubscriber>();
        }

        // Методы управления подпиской.
        public void Subscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Publisher: Attach the subscriber!");
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Publisher: Detach the subscriber!");
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            Console.WriteLine("Publisher: Notify the subscriber!");

            foreach (var currSubscriber in _subscribers)
            {
                currSubscriber.GetUpdate(this);
            }
        }
        
        // Обычно логика подписки – только часть того, что делает Издатель.
        // Издатели часто содержат некоторую важную бизнес-логику, которая
        // запускает метод уведомления всякий раз, когда должно произойти что-то
        // важное (или после этого).
        public void BusinessLogic()
        {
            //Здесь эмулируем какую-то логику, чтобы происходило изменение в классе ИЗДАТЕЛЬ
            Console.WriteLine("\nSubject: I'm doing something important.");
            State = new Random().Next(0, 50);
            
            Thread.Sleep(1000);
            
            Console.WriteLine("Subject: My state has just changed to: " + State);
            //Извещаем подписчиков о событии
            Notify();
        }
    }
}