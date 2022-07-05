using System;
using Strategy_Example.Example1.Realization;
using Strategy_Example.Example2.Abstractions;

namespace Strategy_Example.Example2.Realization
{
    public sealed class Car
    {
        private IMovable _movable;
        protected int _countOfPassengers;
        protected string _carName;

        public Car(
            int countOfPassengers, 
            string carName)
        {
            _countOfPassengers = countOfPassengers;
            _carName = carName;

            Console.WriteLine($"Транспортное средство: {_carName}\nВместимость: {_countOfPassengers}");
        }

        public void Move()
        {
            _movable.Move();
        }

        public void SetStrategy(IMovable movable)
        {
            _movable = movable;
        }
    }
}