using System;
using Iterator_Example.Example1.Realization;
using Iterator_Example.Example2.Realization;

namespace Iterator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код может знать или не знать о Конкретном Итераторе
            // или классах Коллекций, в зависимости от уровня косвенности,
            // который вы хотите сохранить в своей программе.
            {
                WordsCollection wordsCollection = new WordsCollection();
                wordsCollection.AddItem("One item");
                wordsCollection.AddItem("Two items");
                wordsCollection.AddItem("Three items");
                wordsCollection.AddItem("Four items");
                
                Console.WriteLine("Straight traversal:");
                foreach (var item in wordsCollection)
                {
                    Console.WriteLine(item);
                }
                
                Console.WriteLine("\nReverse traversal:");
                wordsCollection.ReverseDirection();

                foreach (var item in wordsCollection)
                {
                    Console.WriteLine(item);
                }
            }

            {
                Library library = new Library();
                Reader reader = new Reader();
                reader.SeeBooks(library);
            }
        }
    }
}