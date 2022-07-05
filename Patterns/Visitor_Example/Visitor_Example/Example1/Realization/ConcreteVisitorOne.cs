using System;
using Visitor_Example.Example1.Abstractions;

namespace Visitor_Example.Example1.Realization
{
    // Конкретные Посетители реализуют несколько версий одного и того же
    // алгоритма, которые могут работать со всеми классами конкретных
    // компонентов.
    //
    // Максимальную выгоду от паттерна Посетитель вы почувствуете, используя его
    // со сложной структурой объектов, такой как дерево Компоновщика. В этом
    // случае было бы полезно хранить некоторое промежуточное состояние
    // алгоритма при выполнении методов посетителя над различными объектами
    // структуры.
    public class ConcreteVisitorOne : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + "<---ConcreteVisitor A");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentB() + "<---ConcreteVisitor B");
        }
    }
}