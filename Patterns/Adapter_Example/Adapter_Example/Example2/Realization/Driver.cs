using Adapter_Example.Example2.Abstractions;

namespace Adapter_Example.Example2.Realization
{
    public class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}