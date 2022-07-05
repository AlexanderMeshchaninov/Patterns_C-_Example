namespace FactoryMethod_Example.Example1
{
    public sealed class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "[Result from ConcreteProduct1]";
        }
    }
}