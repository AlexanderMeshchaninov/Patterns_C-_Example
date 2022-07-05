using System;
using System.Threading.Channels;

namespace Facade_Example.Example2.Realization
{
    public class Clr
    {
        public void Execute()
        {
            Console.WriteLine("Запуск приложения...");
        }

        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения!");
        }
    }
}