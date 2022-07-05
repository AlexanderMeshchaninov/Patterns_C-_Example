using System;
using Facade_Example.Example1.Realization;
using Facade_Example.Example2.Realization;

namespace Facade_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // В клиентском коде могут быть уже созданы некоторые объекты
                // подсистемы. В этом случае может оказаться целесообразным
                // инициализировать Фасад с этими объектами вместо того, чтобы
                // позволить Фасаду создавать новые экземпляры.
                SubsystemA subsystemA = new SubsystemA();
                SubsystemB subsystemB = new SubsystemB();
                Facade facade = new Facade(subsystemA, subsystemB);
                Client.ClientCode(facade);
            }
            {
                TextEditor textEditor = new TextEditor();
                Compiler compiler = new Compiler();
                Clr clr = new Clr();

                VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiler, clr);

                Programmer programmer = new Programmer();
                programmer.CreateApplication(ide);
            }
        }
    }
}