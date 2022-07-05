using System;
using System.Collections.Generic;
using FactoryMethod_Example.Example1;
using FactoryMethod_Example.Example2;
using FactoryMethod_Example.Example3.Abstractions;
using FactoryMethod_Example.Example3.Realization;

namespace FactoryMethod_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // var client = new Client();
                //
                // client.ClientCode(new ConcreteFactory1());
                // client.ClientCode(new ConcreteFactory2());
                // client.ClientCode(new SberbankFactory());
                // client.ClientCode(new VtbFactory());
                //
                // var sberFactory = new SberbankFactory();
                // sberFactory.FactoryMethod();
            }

            //Пример с печатанием денег
            {
                var machines = new List<CashMachineBase>()
                {
                    new RubleCashMachine(),
                    new DollarCashMachine()
                };

                var money = new List<MoneyBase>();
                
                var rnd = new Random();

                foreach (var machine in machines)
                {
                    var pageCount = rnd.Next(1, 3);

                    var newMoney = machine.Create(pageCount);
                    
                    money.AddRange(newMoney);
                }

                foreach (var result in money)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}