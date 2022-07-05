namespace ChainOfResponsibility_Example.Example1.Abstractions
{
    // Поведение цепочки по умолчанию может быть реализовано внутри базового
    // класса обработчика (опционально)
    public abstract class HandlerBase : IHandler
    {
        //ссылка 
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            
            // Возврат обработчика отсюда позволит связать обработчики простым
            // способом, вот так:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler is not null)
            {
                return _nextHandler.Handle(request);
            }

            return null;
        }
    }
}