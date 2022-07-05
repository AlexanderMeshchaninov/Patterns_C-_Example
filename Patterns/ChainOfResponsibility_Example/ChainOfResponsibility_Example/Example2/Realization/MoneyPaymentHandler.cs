using System;
using ChainOfResponsibility_Example.Example2.Abstractions;

namespace ChainOfResponsibility_Example.Example2.Realization
{
    public class MoneyPaymentHandler : PaymentHandlerBase
    {
        public override Receiver Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через систему дережных переводов");
            }

            return base.Handle(receiver);
        }
    }
}