using State_Example.Example1.Realization;

namespace State_Example.Example1.Abstractions
{
    // Базовый класс Состояния объявляет методы, которые должны реализовать все
    // Конкретные Состояния, а также предоставляет обратную ссылку на объект
    // Контекст, связанный с Состоянием. Эта обратная ссылка может
    // использоваться Состояниями для передачи Контекста другому Состоянию.
    public abstract class StateBase
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract void HandleOne();
        public abstract void HandleTwo();
    }
}