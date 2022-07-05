using System;
using Visitor_Example.Example2.Abstractions;

namespace Visitor_Example.Example2.Realization
{
    public class XmlVisitor : IMyVisitor
    {
        public void VisitPersonAccount(Person person)
        {
            string result = "<Person>" +
                            "<FirstName>"+person.FirstName+"</FirstName>" +
                            "<LastName>"+person.LastName+"</LastName>" +
                            "<AccountNumber>"+person.AccountNumber+"</AccountNumber>" +
                            "<Person>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAccount(Company company)
        {
            string result = "<Person>" +
                            "<CompanyName>"+company.CompanyName+"</CompanyName>" +
                            "<RegistryNumber>"+company.RegistryNumber+"</RegistryNumber>" +
                            "<AccountNumber>"+company.AccountNumber+"</AccountNumber>" +
                            "<Person>";
            Console.WriteLine(result);
        }
    }
}