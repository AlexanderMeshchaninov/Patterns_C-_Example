using Iterator_Example.Example2.Realization;

namespace Iterator_Example.Example2.Abstractions
{
    //Интерфейс итератора
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}