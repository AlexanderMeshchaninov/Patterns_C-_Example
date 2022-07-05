namespace FactoryMethod_Example.Example1
{
    public sealed class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "[Result from ConcreteProduct2]";
        }
    }
}