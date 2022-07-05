namespace ObjectPool_Example.Abstractions
{
    public interface ICreation<T>
    {
        T Create();
    }
}