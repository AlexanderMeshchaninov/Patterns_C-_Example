using ChainOfResponsibility_Example.Example1.Abstractions;

namespace ChainOfResponsibility_Example.Example1.Realization
{
    public class ParrotHandler : HandlerBase
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "seeds")
            {
                return $"Parrot: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
}