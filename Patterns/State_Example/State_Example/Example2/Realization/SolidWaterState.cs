using System;
using State_Example.Example2.Abstractions;

namespace State_Example.Example2.Realization
{
    public class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморожку льда");
        }
    }
}