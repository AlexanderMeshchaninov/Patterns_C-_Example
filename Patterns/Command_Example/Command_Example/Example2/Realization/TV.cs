using System;

namespace Command_Example.Example2.Realization
{
    // Receiver - Получатель
    public class TV
    {
        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void Off()
        {
            Console.WriteLine("TV is OFF");
        }
    }
}