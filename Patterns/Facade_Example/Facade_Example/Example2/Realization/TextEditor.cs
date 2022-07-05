using System;

namespace Facade_Example.Example2.Realization
{
    public class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода...");
        }

        public void Save()
        {
            Console.WriteLine("Сохранение кода...");
        }
    }
}