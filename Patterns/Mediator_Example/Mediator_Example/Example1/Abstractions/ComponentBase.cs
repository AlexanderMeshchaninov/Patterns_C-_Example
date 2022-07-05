namespace Mediator_Example.Example1.Abstractions
{
    // Базовый Компонент обеспечивает базовую функциональность хранения
    // экземпляра посредника внутри объектов компонентов.
    public abstract class ComponentBase
    {
        protected IMediator _mediator;

        public ComponentBase(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}