using System;
using FactoryMethod_Example.Example3.Abstractions;

namespace FactoryMethod_Example.Example3.Realization
{
    public class Dollar : MoneyBase
    {
        public int Number { get; private set; }
        public int Denomination { get; private set; }
        
        public Dollar(int denomination) : base("Доллар США", "$")
        {
            if (denomination <= 0)
            {
                throw new ArgumentException("denomination must be more than zero", nameof(denomination));
            }

            var rnd = new Random();
            
            Denomination = denomination;

            Number = rnd.Next(1000, 9999);
        }
        
        public override string ToString()
        {
            return $"{CurrencyName} {Number} номиналом {Denomination}-{CurrencySymbol}";
        }
    }
}