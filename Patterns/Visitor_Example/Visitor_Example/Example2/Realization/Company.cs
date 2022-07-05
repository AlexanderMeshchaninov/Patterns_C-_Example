using System;
using Visitor_Example.Example1.Abstractions;
using Visitor_Example.Example2.Abstractions;

namespace Visitor_Example.Example2.Realization
{
    //Юридическое лицо
    public class Company : IMyAccount
    {
        public string CompanyName { get; set; }
        public string RegistryNumber { get; set; }
        public string AccountNumber { get; set; }

        public void Accept(IMyVisitor visitor)
        {
            visitor.VisitCompanyAccount(this);
        }
    }
}