using Iterator_Example.Example1.Abstractions;

namespace Iterator_Example.Example1.Realization
{
    // Конкретные Итераторы реализуют различные алгоритмы обхода. Эти классы
    // постоянно хранят текущее положение обхода.
    public class AlphabeticalOrderIterator : IteratorBase
    {
        private WordsCollection _wordsCollection;

        // Хранит текущее положение обхода. У итератора может быть множество
        // других полей для хранения состояния итерации, особенно когда он
        // должен работать с определённым типом коллекции.
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(
            WordsCollection wordsCollection,
            bool reverse = false)
        {
            _wordsCollection = wordsCollection;
            _reverse = reverse;

            if (reverse)
            {
                _position = _wordsCollection.GetItems().Count;
            }
        }

        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return _wordsCollection.GetItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _wordsCollection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _wordsCollection.GetItems().Count - 1 : 0;
        }
    }
}