using FactoryMethod_Example.Example1;

namespace FactoryMethod_Example.Example2
{
    public class VtbFactory : AbstractFactory
    {
        public override IProduct FactoryMethod()
        {
            return new Vtb();
        }
    }
}