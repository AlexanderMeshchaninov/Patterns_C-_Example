using System;
using Command_Example.Example1.Abstractions;

namespace Command_Example.Example1.Realization
{
    // Отправитель связан с одной или несколькими командами. Он отправляет
    // запрос команде.
    public sealed class Invoker
    {
        //Ссылки на команды (работаем через общий интерфейс комманд)
        private ICommand _onStart;
        private ICommand _onFinish;

        // Инициализация команд
        public void OnStart(ICommand onStart)
        {
            _onStart = onStart;
        }

        public void OnFinish(ICommand onFinish)
        {
            _onFinish = onFinish;
        }

        // Отправитель не зависит от классов конкретных команд и получателей.
        // Отправитель передаёт запрос получателю косвенно, выполняя команду.
        public void DoSomethingImportant()
        {
            Console.WriteLine(
                "Invoker: Does anybody want something done before I begin?");
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }
            
            Console.WriteLine(
                "Invoker: ...doing something really important...");
            
            Console.WriteLine(
                "Invoker: Does anybody want something done after I finish?");
            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}