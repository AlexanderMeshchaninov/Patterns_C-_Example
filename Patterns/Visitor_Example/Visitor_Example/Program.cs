using System;
using System.Collections.Generic;
using Visitor_Example.Example1.Abstractions;
using Visitor_Example.Example1.Realization;
using Visitor_Example.Example2.Realization;

namespace Visitor_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var components = new List<IComponent>()
                {
                    new ConcreteComponentA(),
                    new ConcreteComponentB()
                };
                
                Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
                
                var visitorOne = new ConcreteVisitorOne();
                Client.ClientCode(components, visitorOne);

                Console.WriteLine("It allows the same client code to work with different types of visitors:");
                var visitorTwo = new ConcreteVisitorTwo();
                Client.ClientCode(components, visitorTwo);
            }

            {
                var structure = new Bank();
                structure.Add(new Person()
                {
                    FirstName = "Alexander",
                    LastName = "Meshchaninov",
                    AccountNumber = "111"
                });
                structure.Add(new Company()
                {
                    CompanyName = "Samsung",
                    RegistryNumber = "33444",
                    AccountNumber = "367940377382932"
                });
                
                structure.Accept(new HtmlVisitor());
                structure.Accept(new XmlVisitor());
            }

            {
                
            }
        }
    }
}