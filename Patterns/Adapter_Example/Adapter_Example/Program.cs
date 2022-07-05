using System;
using Adapter_Example.Abstractions;
using Adapter_Example.Example2.Abstractions;
using Adapter_Example.Example2.Realization;
using Adapter_Example.Realization;

namespace Adapter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Adaptee adaptee = new Adaptee();

                ITarget target = new Adapter(adaptee);
            
                Console.WriteLine("Adaptee interface is incompatible with the client.");
                Console.WriteLine("But with adapter client can call it's method.");

                Console.WriteLine(target.GetRequest());
            }
            {
                // путешественник
                Driver driver = new Driver();
                // машина
                Auto auto = new Auto();
                // отправляемся в путешествие
                driver.Travel(auto);
                // встретились пески, надо использовать верблюда
                Camel camel = new Camel();
                // используем адаптер
                ITransport camelTransport = new CamelToTransportAdapter(camel);
                // продолжаем путь по пескам пустыни
                driver.Travel(camelTransport);
 
                Console.Read();
            }
        }
    }
}