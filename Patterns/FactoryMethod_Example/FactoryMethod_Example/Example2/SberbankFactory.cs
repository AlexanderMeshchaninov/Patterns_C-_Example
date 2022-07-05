using FactoryMethod_Example.Example1;

namespace FactoryMethod_Example.Example2
{
    public sealed class SberbankFactory : AbstractFactory
    {
        public override IProduct FactoryMethod()
        {
            return new Sberbank();
        }
    }
}