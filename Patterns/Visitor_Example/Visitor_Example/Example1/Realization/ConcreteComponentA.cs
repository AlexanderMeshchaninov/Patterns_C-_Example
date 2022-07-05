using Visitor_Example.Example1.Abstractions;

namespace Visitor_Example.Example1.Realization
{
    // Каждый Конкретный Компонент должен реализовать метод Accept таким
    // образом, чтобы он вызывал метод посетителя, соответствующий классу
    // компонента.
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }
        
        // Конкретные Компоненты могут иметь особые методы, не объявленные в их
        // базовом классе или интерфейсе. Посетитель всё же может использовать
        // эти методы, поскольку он знает о конкретном классе компонента.
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "[This is special method of component A]";
        }
    }
}