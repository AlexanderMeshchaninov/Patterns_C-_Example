using System;

namespace FactoryMethod_Example.Example3.Abstractions
{
    public abstract class CashMachineBase
    {
        public string MachineName { get; protected set; }

        public CashMachineBase(string machineName)
        {
            if (string.IsNullOrEmpty(machineName))
            {
                throw new ArgumentException("Machine name empty");
            }

            MachineName = machineName;
        }

        public abstract MoneyBase[] Create(int pageCount);

        public override string ToString()
        {
            return MachineName;
        }
    }
}