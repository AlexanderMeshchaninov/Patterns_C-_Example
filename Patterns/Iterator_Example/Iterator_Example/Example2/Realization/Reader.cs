using System;
using Iterator_Example.Example2.Abstractions;

namespace Iterator_Example.Example2.Realization
{
    //Выступает в качесте клиента (читателя), который хочет перебрать коллекцию книг.
    public class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();

            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.BookName);
            }
        }
    }
}