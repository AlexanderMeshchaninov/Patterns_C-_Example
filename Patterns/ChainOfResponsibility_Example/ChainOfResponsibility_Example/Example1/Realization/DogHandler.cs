using ChainOfResponsibility_Example.Example1.Abstractions;

namespace ChainOfResponsibility_Example.Example1.Realization
{
    public class DogHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "bone")
            {
                return $"Dog: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
}