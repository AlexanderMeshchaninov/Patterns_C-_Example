using System.Collections.Generic;
using System.Linq;
using Strategy_Example.Example1.Abstractions;

namespace Strategy_Example.Example1.Realization
{
    // Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу
    // Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
    public sealed class GoByFoot : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var contentDict = data as Dictionary<string, string>;

            var result = contentDict
                .Where(x => x.Key == "GoByFoot")
                .FirstOrDefault()
                .Value;

            return result;
        }
    }
}