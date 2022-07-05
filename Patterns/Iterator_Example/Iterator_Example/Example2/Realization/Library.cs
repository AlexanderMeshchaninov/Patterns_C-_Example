using Iterator_Example.Example2.Abstractions;

namespace Iterator_Example.Example2.Realization
{
    //Коллекция которую мы перебираем
    public class Library : IBookNumerable
    {
        private Book[] _books;

        public Library()
        {
            _books = new Book[]
            {
                new Book(){BookName = "Война и мир"},
                new Book(){BookName = "Властелин Колец"},
                new Book(){BookName = "Хоббит туда и обратно"},
                new Book(){BookName = "Отцы и дети"},
                new Book(){BookName = "Вишневый сад"},
                new Book(){BookName = "Метро 2033"}
            };
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }

        public int Count
        {
            get => _books.Length;
        }

        public Book this[int index]
        {
            get => _books[index];
        }
    }
}