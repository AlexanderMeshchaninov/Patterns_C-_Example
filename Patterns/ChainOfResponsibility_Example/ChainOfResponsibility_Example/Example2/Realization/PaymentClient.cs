using System;
using System.Collections.Generic;
using ChainOfResponsibility_Example.Example2.Abstractions;

namespace ChainOfResponsibility_Example.Example2.Realization
{
    public sealed class PaymentClient
    {
        public static void ClientCode(PaymentHandlerBase handler, Receiver receiver)
        {
            var transfer = new List<Receiver>();
            transfer.Add(receiver);

            foreach (var tr in transfer)
            {
                var result = handler.Handle(tr);

                if (result is not null)
                {
                    Console.Write($"{result}");
                }
                else
                {
                    Console.WriteLine($"Nothing transferred");
                }
            }
        }
    }
}