using Command_Example.Example2.Abstractions;

namespace Command_Example.Example2.Realization
{
    //Команда включения и выключения ТВ
    public class TVOnCommand : IMyCommand
    {
        private TV _tv;

        public TVOnCommand(TV tvOnSet)
        {
            _tv = tvOnSet;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}