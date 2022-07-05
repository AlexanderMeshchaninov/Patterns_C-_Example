using System;
using FactoryMethod_Example.Example3.Abstractions;

namespace FactoryMethod_Example.Example3.Realization
{
    public sealed class Ruble : MoneyBase
    {
        public Guid Identity { get; private set; }
        public int Number { get; private set; }
        public int Denomination { get; private set; }

        public Ruble(int denomination) : base("Russian ruble", "Rub")
        {
            if (denomination <= 0)
            {
                throw new ArgumentException("Denomination must be more than zero", nameof(denomination));
            }

            var rnd = new Random();

            Number = rnd.Next(10000, 99999);
            Denomination = denomination;
            Identity = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{CurrencyName} {Number} [{Identity}] номиналом {Denomination}-{CurrencySymbol}";
        }
    }
}