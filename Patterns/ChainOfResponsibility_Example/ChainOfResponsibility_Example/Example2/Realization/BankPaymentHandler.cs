using System;
using ChainOfResponsibility_Example.Example2.Abstractions;

namespace ChainOfResponsibility_Example.Example2.Realization
{
    public class BankPaymentHandler : PaymentHandlerBase
    {
        public override Receiver Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
            {
                Console.WriteLine("Выполняем банковский перевод");
            }

            return base.Handle(receiver);
        }
    }
}