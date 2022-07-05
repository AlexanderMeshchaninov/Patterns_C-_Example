using System;
using Visitor_Example.Example1.Abstractions;
using Visitor_Example.Example2.Abstractions;

namespace Visitor_Example.Example2.Realization
{
    // физическое лицо
    public class Person : IMyAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        
        public void Accept(IMyVisitor visitor)
        {
            visitor.VisitPersonAccount(this);
        }
    }
}