using System;

namespace ObjectPool_Example.Realization
{
    public sealed class Reusable
    {
        public Object[] Objects { get; protected set; }

        public Reusable(params Object[] objects)
        {
            Objects = objects;
        }
    }
}