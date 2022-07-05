using System;
using ICommand = Command_Example.Example1.Abstractions.ICommand;

namespace Command_Example.Example1.Realization
{
    // Некоторые команды способны выполнять простые операции самостоятельно.
    public sealed class SimpleCommand : ICommand
    {
        private string _payLoad = string.Empty;

        public SimpleCommand(string payLoad)
        {
            _payLoad = payLoad;
        }

        public void Execute()
        {
            Console.WriteLine(
                $"SimpleCommand: See, I can do simple things like printing ({_payLoad})");
        }
    }
}