using FactoryMethod_Example.Example1;

namespace FactoryMethod_Example.Example2
{
    public sealed class Sberbank : IProduct
    {
        public string Operation()
        {
            return "Sberbank has build!";
        }
    }
}