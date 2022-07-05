namespace Visitor_Example.Example1.Abstractions
{
    // Интерфейс Компонента объявляет метод accept, который в качестве аргумента
    // может получать любой объект, реализующий интерфейс посетителя.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}