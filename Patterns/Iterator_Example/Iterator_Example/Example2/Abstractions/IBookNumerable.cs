using Iterator_Example.Example2.Realization;

namespace Iterator_Example.Example2.Abstractions
{
    //
    public interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}