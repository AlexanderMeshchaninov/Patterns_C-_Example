using ChainOfResponsibility_Example.Example2.Realization;

namespace ChainOfResponsibility_Example.Example2.Abstractions
{
    public abstract class PaymentHandlerBase : IPaymentHandler
    {
        private IPaymentHandler _paymentHandlerNext;
        public IPaymentHandler SetNext(IPaymentHandler handler)
        {
            _paymentHandlerNext = handler;

            return handler;
        }

        public virtual Receiver Handle(Receiver request)
        {
            if (_paymentHandlerNext is not null)
            {
                return _paymentHandlerNext.Handle(request);
            }

            return null;
        }
    }
}