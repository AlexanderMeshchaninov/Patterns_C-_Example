using ChainOfResponsibility_Example.Example1.Abstractions;

namespace ChainOfResponsibility_Example.Example1.Realization
{
    public class CatHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "milk")
            {
                return $"Cat: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
}