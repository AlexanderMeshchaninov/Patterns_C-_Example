using System;
using Adapter_Example.Example2.Abstractions;

namespace Adapter_Example.Example2.Realization
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}