using System;
using Visitor_Example.Example2.Abstractions;

namespace Visitor_Example.Example2.Realization
{
    public class HtmlVisitor : IMyVisitor
    {
        public void VisitPersonAccount(Person person)
        {
            string result = "<table><tr><td>Property<td><td>Value</td></tr>";
            result += "<tr><td>First name<td><td>" + person.FirstName + "</td></tr>";
            result += "<tr><td>Last name<td><td>" + person.LastName + "</td></tr>";
            result += "<tr><td>Account number<td><td>" + person.AccountNumber + "</td></tr></table>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAccount(Company company)
        {
            string result = "<table><tr><td>Property<td><td>Value</td></tr>";
            result += "<tr><td>Company name<td><td>" + company.CompanyName + "</td></tr>";
            result += "<tr><td>Registry number<td><td>" + company.RegistryNumber + "</td></tr>";
            result += "<tr><td>Account number<td><td>" + company.AccountNumber + "</td></tr></table>";
            Console.WriteLine(result);
        }
    }
}