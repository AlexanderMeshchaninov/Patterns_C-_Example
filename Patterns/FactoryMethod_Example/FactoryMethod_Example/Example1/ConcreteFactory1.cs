namespace FactoryMethod_Example.Example1
{
    public sealed class ConcreteFactory1 : AbstractFactory
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}