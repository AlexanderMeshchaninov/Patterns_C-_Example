namespace Observer_Example.Example1.Abstractions
{
    public interface IPublisher
    {
        //Присоединить наблюдателя (подписать)
        void Subscribe(ISubscriber subscriber);
        //Отсоединить наблюдателя (отписать)
        void Unsubscribe(ISubscriber subscriber);
        //Проинформировать о событии
        void Notify();
    }
}