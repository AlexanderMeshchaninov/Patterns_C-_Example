namespace Observer_Example.Example1.Abstractions
{
    // Получает обновление от издателя
    public interface ISubscriber
    {
        void GetUpdate(IPublisher publisher);
    }
}