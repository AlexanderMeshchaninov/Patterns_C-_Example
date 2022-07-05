using System;
using System.Threading.Tasks;

namespace Command_Example.Example2.Realization
{
    public class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Microwave starting...");
            // имитация работы с помощью асинхронного метода Task.Delay
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopCooking()
        {
            Console.WriteLine("Microwave stop cooking...");
        }
    }
}