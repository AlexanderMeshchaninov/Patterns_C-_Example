using System;
using Command_Example.Example1.Abstractions;

namespace Command_Example.Example1.Realization
{
    // Но есть и команды, которые делегируют более сложные операции другим
    // объектам, называемым «получателями».
    public sealed class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        
        // Данные о контексте, необходимые для запуска методов получателя.
        private string _a;
        private string _b;
        
        // Сложные команды могут принимать один или несколько объектов-
        // получателей вместе с любыми данными о контексте через конструктор.
        public ComplexCommand(
            Receiver receiver,
            string a,
            string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        // Команды могут делегировать выполнение любым методам получателя.
        public void Execute()
        {
            Console.WriteLine(
                "ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}