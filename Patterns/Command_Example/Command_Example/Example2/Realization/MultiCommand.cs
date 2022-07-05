using System.Collections.Generic;
using Command_Example.Example2.Abstractions;

namespace Command_Example.Example2.Realization
{
    //Класс агрегирующий множество комманд, через него можно работать выполняя разные команды и содержит Stack()
    public class MultiCommand
    {
        //Массив комманд
        private IMyCommand[] _buttons;
        //В Stack() будем записывать историю выполненных комманд
        private Stack<IMyCommand> _commandHistory;

        public MultiCommand()
        {
            _buttons = new IMyCommand[2];

            for (int i = 0; i < _buttons.Length; i++)
            {
                //Записываем "пустые комманды т.е. ничего null"
                _buttons[i] = null;
            }

            _commandHistory = new Stack<IMyCommand>();
        }

        public void SetCommand(int number, IMyCommand command)
        {
            _buttons[number] = command;
        }

        public void PressButton(int number)
        {
            _buttons[number].Execute();
            
            //Добавляем выполненную команду в историю команд...
            _commandHistory.Push(_buttons[number]);
        }

        public void PressUndoButton()
        {
            if (_commandHistory.Count > 0)
            {
                //Убираем из стека комманды
                IMyCommand undoCommand = _commandHistory.Pop();
                undoCommand.Undo();
            }
        }
    }
}