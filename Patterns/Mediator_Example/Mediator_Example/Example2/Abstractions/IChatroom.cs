namespace Mediator_Example.Example2.Abstractions
{
    //Интерфейс посредника (медиатора)
    public interface IChatroom
    {
        void Register(ParticipantBase participant);
        void SendMessage(string from, string to, string message);
    }
}