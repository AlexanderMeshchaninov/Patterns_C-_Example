namespace FactoryMethod_Example.Example1
{
    public abstract class AbstractFactory
    {
        public abstract IProduct FactoryMethod();

        public string Operation()
        {
            var product = FactoryMethod();

            var result = "[Some business logic from abstractCreator] " + product.Operation();

            return result;
        }
    }
}