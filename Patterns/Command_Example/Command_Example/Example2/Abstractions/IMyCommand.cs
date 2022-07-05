namespace Command_Example.Example2.Abstractions
{
    public interface IMyCommand
    {
        void Execute();
        void Undo();
    }
}