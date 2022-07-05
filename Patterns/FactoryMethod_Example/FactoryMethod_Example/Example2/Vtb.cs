using FactoryMethod_Example.Example1;

namespace FactoryMethod_Example.Example2
{
    public sealed class Vtb : IProduct
    {
        public string Operation()
        {
            return "VTB has build!";
        }
    }
}