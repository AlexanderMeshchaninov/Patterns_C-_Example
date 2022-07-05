using System.Collections;

namespace Iterator_Example.Example1.Abstractions
{
    public abstract class IteratorAggregateBase : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }
}