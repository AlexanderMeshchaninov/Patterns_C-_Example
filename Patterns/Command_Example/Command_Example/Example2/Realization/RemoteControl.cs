using Command_Example.Example2.Abstractions;

namespace Command_Example.Example2.Realization
{
    //Invoker - инициатор
    public class RemoteControl
    {
        private IMyCommand _myCommand;

        public RemoteControl() { }

        public void SetCommand(IMyCommand myCommand)
        {
            _myCommand = myCommand;
        }

        public void PressButton()
        {
            if (_myCommand is not null)
            {
                _myCommand.Execute();
            }
        }

        public void PressUndo()
        {
            if (_myCommand is not null)
            {
                _myCommand.Undo();
            }
        }
    }
}