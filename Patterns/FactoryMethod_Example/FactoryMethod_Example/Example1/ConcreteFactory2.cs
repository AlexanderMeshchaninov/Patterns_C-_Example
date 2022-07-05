namespace FactoryMethod_Example.Example1
{
    public sealed class ConcreteFactory2 : AbstractFactory
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}