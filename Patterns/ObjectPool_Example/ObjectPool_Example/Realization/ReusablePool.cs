using ObjectPool_Example.Abstractions;

namespace ObjectPool_Example.Realization
{
    public sealed class ReusablePool : ObjectPool<Reusable>
    {
        public ReusablePool()
            : base(new Creator(), 2)
        {
        }
    }
}