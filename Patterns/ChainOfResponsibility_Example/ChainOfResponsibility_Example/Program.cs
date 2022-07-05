using System;
using ChainOfResponsibility_Example.Example1.Realization;
using ChainOfResponsibility_Example.Example2.Realization;

namespace ChainOfResponsibility_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Другая часть клиентского кода создает саму цепочку.
                var monkey = new MonkeyHandler();
                var dog = new DogHandler();
                var cat = new CatHandler();
                var parrot = new ParrotHandler();
                
                //Выстраиваем цепочку
                monkey.SetNext(dog).SetNext(cat).SetNext(parrot);
                
                // Клиент должен иметь возможность отправлять запрос любому
                // обработчику, а не только первому в цепочке.
                Console.WriteLine("Chain: Monkey > Dog > Cat\n");
                
                Client.ClientCode(monkey);
                Console.WriteLine();

                Console.WriteLine("Subchain: Cat > Parrot\n");
                Client.ClientCode(cat);
            }

            {
                var receiver = new Receiver(true, true, true);
         
                var bankPaymentHandler = new BankPaymentHandler();
                var moneyPaymentHadler = new MoneyPaymentHandler();
                var paypalPaymentHandler = new PayPalPaymentHandler();

                bankPaymentHandler.SetNext(moneyPaymentHadler).SetNext(paypalPaymentHandler);
                
                PaymentClient.ClientCode(bankPaymentHandler, receiver);
                Console.Read();
            }
        }
    }
}