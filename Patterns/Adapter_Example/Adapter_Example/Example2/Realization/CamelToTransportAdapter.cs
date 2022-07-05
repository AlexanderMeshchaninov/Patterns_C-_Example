using Adapter_Example.Example2.Abstractions;

namespace Adapter_Example.Example2.Realization
{
    // Адаптер от Camel к ITransport
    public class CamelToTransportAdapter : ITransport
    {
        private readonly Camel _camel;

        public CamelToTransportAdapter(Camel camel)
        {
            _camel = camel;
        }

        public void Drive()
        {
            _camel.Move();
        }
    }
}