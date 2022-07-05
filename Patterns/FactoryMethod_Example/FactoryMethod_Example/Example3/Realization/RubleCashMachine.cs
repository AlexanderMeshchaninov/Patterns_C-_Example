using System;
using System.Collections.Generic;
using System.Linq;
using FactoryMethod_Example.Example3.Abstractions;

namespace FactoryMethod_Example.Example3.Realization
{
    public class RubleCashMachine : CashMachineBase
    {
        private readonly int _countPage = 64;
        private readonly int _denomination;
        private int[] _correctDenomination = {50, 100, 1000, 5000};
        
        public RubleCashMachine(int denomination = 1000) : base("Dollar cash machine")
        {
            if(denomination <= 0)
            {
                throw new ArgumentException("denomination must be more than zero", nameof(denomination));
            }
            
            if(!_correctDenomination.Contains(denomination))
            {
                throw new ArgumentException($"Do not correct denomination", nameof(denomination));
            }
            
            _denomination = denomination;
        }

        public override MoneyBase[] Create(int pageCount)
        {
            var count = _countPage * pageCount;

            var money = new List<MoneyBase>();

            for (int i = 0; i < count; i++)
            {
                var ruble = new Ruble(_denomination);
                money.Add(ruble);
            }

            return money.ToArray();
        }
    }
}