using System;
using State_Example.Example1.Abstractions;

namespace State_Example.Example1.Realization
{
    // Контекст определяет интерфейс, представляющий интерес для клиентов. Он
    // также хранит ссылку на экземпляр подкласса Состояния, который отображает
    // текущее состояние Контекста.
    public class Context
    {
        // Ссылка на текущее состояние Контекста.
        private StateBase _state = null;

        public Context(StateBase state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(StateBase state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        // Контекст делегирует часть своего поведения текущему объекту
        // Состояния.
        public void RequestOne()
        {
            _state.HandleOne();
        }

        public void RequestTwo()
        {
            _state.HandleTwo();
        }
    }
}