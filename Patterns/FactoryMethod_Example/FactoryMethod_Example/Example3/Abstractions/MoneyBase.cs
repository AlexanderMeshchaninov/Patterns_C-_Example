using System;

namespace FactoryMethod_Example.Example3.Abstractions
{
    public abstract class MoneyBase
    {
        public string CurrencyName { get; protected set; }
        public string CurrencySymbol { get; protected set; }

        public MoneyBase(string currencyName, string currencySymbol)
        {
            if (string.IsNullOrEmpty(currencyName))
            {
                throw new ArgumentException("currencyName empty");
            }
            
            if (string.IsNullOrEmpty(currencySymbol))
            {
                throw new ArgumentException("currencySymbol empty");
            }

            CurrencyName = currencyName;
            CurrencySymbol = currencySymbol;
        }

        public override string ToString()
        {
            return CurrencyName;
        }
    }
}