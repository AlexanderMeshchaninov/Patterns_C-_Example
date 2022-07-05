using System;

namespace Singleton_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Singleton singleton1 = Singleton.GetInstance();
                singleton1.SomeBusinessLogic();
                int hash1 = singleton1.GetHashCode();
            
                Singleton singleton2 = Singleton.GetInstance();
                singleton2.SomeBusinessLogic();
                int hash2 = singleton2.GetHashCode();
            
                if (hash1 == hash2)
                {
                    Console.WriteLine("Are equals!");
                }
                else
                {
                    Console.WriteLine("Not equals!");
                }
            }

            {
                Cup cup = new Cup();
                cup.DrinkWater();
            }

            {
                TeaPot teaPot = new TeaPot();
                teaPot.MakeTea();
            }

            {
                Multiton multiton1 = Multiton.GetInstance(1);
                Multiton multiton2 = Multiton.GetInstance(2);
                
                var hash1 = multiton1.GetHashCode();
                var hash2 = multiton2.GetHashCode();

                Console.WriteLine($"Hashes: {hash1} and {hash2}");
            }
        }
    }
}
