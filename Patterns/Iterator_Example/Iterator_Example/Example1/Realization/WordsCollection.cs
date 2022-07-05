using System.Collections;
using System.Collections.Generic;
using Iterator_Example.Example1.Abstractions;

namespace Iterator_Example.Example1.Realization
{
    // Конкретные Коллекции предоставляют один или несколько методов для
    // получения новых экземпляров итератора, совместимых с классом коллекции.
    public class WordsCollection : IteratorAggregateBase
    {
        private List<string> _wordsCollection = new List<string>();

        private bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _wordsCollection;
        }

        public void AddItem(string addItem)
        {
            _wordsCollection.Add(addItem);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}