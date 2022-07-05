using ObjectPool_Example.Abstractions;

namespace ObjectPool_Example.Realization
{
    public sealed class Creator : ICreation<Reusable>
    {
        private static int _iD = 0;
        public Reusable Create()
        {
            ++_iD;
            return new Reusable(_iD);
        }
    }
}