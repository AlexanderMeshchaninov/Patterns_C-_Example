using Visitor_Example.Example2.Realization;

namespace Visitor_Example.Example2.Abstractions
{
    public interface IMyVisitor
    {
        void VisitPersonAccount(Person person);
        void VisitCompanyAccount(Company company);
    }
}