using System;
using ChainOfResponsibility_Example.Example2.Abstractions;

namespace ChainOfResponsibility_Example.Example2.Realization
{
    public class PayPalPaymentHandler : PaymentHandlerBase
    {
        public override Receiver Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через систему PayPal");
            }

            return base.Handle(receiver);
        }
    }
}