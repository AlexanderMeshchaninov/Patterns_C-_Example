using System;
using State_Example.Example2.Abstractions;

namespace State_Example.Example2.Realization
{
    public class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед");
            water.State = new SolidWaterState();
        }
    }
}