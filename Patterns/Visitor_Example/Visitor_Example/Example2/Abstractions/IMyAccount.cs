using Visitor_Example.Example1.Abstractions;

namespace Visitor_Example.Example2.Abstractions
{
    public interface IMyAccount
    {
        void Accept(IMyVisitor visitor);
    }
}