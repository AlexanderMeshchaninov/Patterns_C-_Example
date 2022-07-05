using Visitor_Example.Example1.Abstractions;

namespace Visitor_Example.Example1.Realization
{
    public class ConcreteComponentB : IComponent
    {
        // Обратите внимание, мы вызываем VisitConcreteComponentA, что
        // соответствует названию текущего класса. Таким образом мы позволяем
        // посетителю узнать, с каким классом компонента он работает.
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }
        
        // Конкретные Компоненты могут иметь особые методы, не объявленные в их
        // базовом классе или интерфейсе. Посетитель всё же может использовать
        // эти методы, поскольку он знает о конкретном классе компонента.
        public string ExclusiveMethodOfConcreteComponentB()
        {
            return "[This is special method of component B]";
        }
    }
}