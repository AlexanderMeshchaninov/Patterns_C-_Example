using ChainOfResponsibility_Example.Example1.Abstractions;

namespace ChainOfResponsibility_Example.Example1.Realization
{
    public class MonkeyHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "banana")
            {
                return $"Monkey: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
}