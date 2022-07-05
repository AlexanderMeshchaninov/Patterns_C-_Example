using System;
using Strategy_Example.Example2.Abstractions;

namespace Strategy_Example.Example2.Realization
{
    public sealed class ElectricCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("еду на электричестве - 0 ---> 100");
        }
    }
}