namespace Decorator_Example.Example1.Abstractions
{
    //Базовый декоратор, который используется с конкретными декораторами
    public class DecoratorBase : ComponentBase
    {
        //Поле для хранения и инициализации базового интерфейса декорируемого объекта
        private ComponentBase _componentBase;
        
        //Инжектируем компонент
        public DecoratorBase(ComponentBase componentBase)
        {
            _componentBase = componentBase;
        }

        //Метод для "установки" коспонента
        public void SetComponent(ComponentBase componentBase)
        {
            _componentBase = componentBase;
        }

        //Делегируем всю работу обернутому компоненту
        public override string Operation()
        {
            if (_componentBase is not null)
            {
                return _componentBase.Operation();
            }

            return string.Empty;
        }
    }
}