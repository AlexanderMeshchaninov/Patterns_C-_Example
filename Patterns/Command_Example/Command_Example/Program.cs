using System;
using Command_Example.Example1.Realization;
using Command_Example.Example2.Realization;

namespace Command_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Клиентский код может параметризовать отправителя любыми
                // командами.
                //Отправитель
                Invoker invoker = new Invoker();
                invoker.OnStart(new SimpleCommand("Hello!"));
                
                //Получатель
                Receiver receiver = new Receiver();
                invoker.OnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
                
                invoker.DoSomethingImportant();
            }

            {
                Console.WriteLine();
                RemoteControl remoteControl = new RemoteControl();
                
                TV tv = new TV();
                Microwave microwave = new Microwave();
                
                remoteControl.SetCommand(new TVOnCommand(tv));
                remoteControl.PressButton();
                remoteControl.PressUndo();

                //5000 - время нагрева пищи
                remoteControl.SetCommand(new MicrowaveCommand(microwave, 5000));
                remoteControl.PressButton();
                remoteControl.PressUndo();
                
                Volume volume = new Volume();
                MultiCommand multiRemote = new MultiCommand();
                // инциализируем две комманды (кнопки)
                multiRemote.SetCommand(0, new TVOnCommand(tv));
                multiRemote.SetCommand(1, new VolumeCommand(volume));
                // включаем телевизор
                multiRemote.PressButton(0);
                // увеличиваем громкость
                multiRemote.PressButton(1);
                multiRemote.PressButton(1);
                multiRemote.PressButton(1);
                // действия отмены
                multiRemote.PressUndoButton();
                multiRemote.PressUndoButton();
                multiRemote.PressUndoButton();
                multiRemote.PressUndoButton();
            }
        }
    }
}