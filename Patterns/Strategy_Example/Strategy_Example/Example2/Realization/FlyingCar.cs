using System;
using Strategy_Example.Example2.Abstractions;

namespace Strategy_Example.Example2.Realization
{
    public class FlyingCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("лечу по воздуху - уууааааа");
        }
    }
}