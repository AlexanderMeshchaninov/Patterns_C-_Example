using Iterator_Example.Example2.Abstractions;

namespace Iterator_Example.Example2.Realization
{
    //Алгоритм с помощью которого мы перебираем объект Библиотека
    public class LibraryNumerator : IBookIterator
    {
        private IBookNumerable _aggregate;
        private int _index = 0;

        public LibraryNumerator(IBookNumerable aggregate)
        {
            _aggregate = aggregate;
        }

        public bool HasNext()
        {
            return (_index < _aggregate.Count);
        }

        public Book Next()
        {
            return _aggregate[_index++];
        }
    }
}