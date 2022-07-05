using System;
using System.Collections.Generic;
using Strategy_Example.Example1.Abstractions;

namespace Strategy_Example.Example1.Realization
{
    // Контекст определяет "интерфейс", представляющий интерес для клиентов.
    public sealed class Context
    {
        // Контекст хранит ссылку на один из объектов Стратегии. Контекст не
        // знает конкретного класса стратегии. Он должен работать со всеми
        // стратегиями через интерфейс Стратегии!
        private IStrategy _strategy;

        public Context() { }

        // Обычно Контекст принимает стратегию через конструктор, а также
        // предоставляет сеттер для её изменения во время выполнения.
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // Обычно Контекст позволяет заменить объект Стратегии во время
        // выполнения.
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // Вместо того, чтобы самостоятельно реализовывать множественные версии
        // алгоритма, Контекст делегирует некоторую работу объекту Стратегии.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: User decides a strategy to go (not sure how it'll do it)");
            
            var responseObj = _strategy.DoAlgorithm(
                new Dictionary<string, string>()
                {
                    {"GoByCar", "User decided to go this route by [CAR]..."},
                    {"GoByCityTransport", "User decided to go this route by [CITY TRANSPORT - METRO]..."},
                    {"GoByFoot", "User decided to go this route by [FOOT]..."},
                });

            string print = responseObj as string;
            
            Console.WriteLine(print);
        }
    }
}