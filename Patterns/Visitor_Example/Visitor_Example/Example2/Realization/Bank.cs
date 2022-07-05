using System.Collections.Generic;
using Visitor_Example.Example1.Abstractions;
using Visitor_Example.Example2.Abstractions;

namespace Visitor_Example.Example2.Realization
{
    public class Bank
    {
        private readonly List<IMyAccount> _accounts;

        public Bank()
        {
            _accounts = new List<IMyAccount>();
        }

        public void Add(IMyAccount account)
        {
            _accounts.Add(account);
        }
        public void Remove(IMyAccount account)
        {
            _accounts.Remove(account);
        }
        public void Accept(IMyVisitor visitor)
        {
            foreach (var acc in _accounts)
            {
                acc.Accept(visitor);
            }
        }
    }
}