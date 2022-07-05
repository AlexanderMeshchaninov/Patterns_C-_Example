using System.Collections.Generic;
using Visitor_Example.Example1.Abstractions;

namespace Visitor_Example.Example1.Realization
{
    public class Client
    {
        public static void ClientCode(IList<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}