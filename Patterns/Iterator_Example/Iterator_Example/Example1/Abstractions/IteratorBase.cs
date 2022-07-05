using System.Collections;

namespace Iterator_Example.Example1.Abstractions
{
    public abstract class IteratorBase : IEnumerator
    {
        object IEnumerator.Current => Current();
        // Возвращает ключ текущего элемента
        public abstract int Key();
        
        // Возвращает текущий элемент.
        public abstract object Current();
        
        // Переходит к следующему элементу.
        public abstract bool MoveNext();
        
        // Перематывает Итератор к первому элементу.
        public abstract void Reset();
    }
}