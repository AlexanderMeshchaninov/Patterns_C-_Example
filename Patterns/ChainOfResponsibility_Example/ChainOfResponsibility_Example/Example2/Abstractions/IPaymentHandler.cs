using ChainOfResponsibility_Example.Example2.Realization;

namespace ChainOfResponsibility_Example.Example2.Abstractions
{
    public interface IPaymentHandler
    {
        IPaymentHandler SetNext(IPaymentHandler handler);
        public Receiver Handle(Receiver request);
    }
}