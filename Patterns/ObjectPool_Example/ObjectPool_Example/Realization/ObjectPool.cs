using System;
using System.Collections;
using System.Threading;
using ObjectPool_Example.Abstractions;

namespace ObjectPool_Example.Realization
{
    public class ObjectPool<T> where T : class
    {
        public int Size
        {
            get
            {
                lock (_pool)
                {
                    return _pool.Count;
                }
            }
        }

        public int InstanceCount
        {
            get => _instanceCount;
        }

        public int MaxInstances
        {
            get => _maxInstances;
            set => _instanceCount = value;
        }
        
        private Semaphore _semaphore;
        private ArrayList _pool;
        private ICreation<T> _creator;
        private int _instanceCount;
        private int _maxInstances;

        public ObjectPool(ICreation<T> creator) : this(creator, int.MaxValue)
        {
        }

        public ObjectPool(ICreation<T> creator, int maxInstances)
        {
            _creator = creator;
            _instanceCount = 0;
            _maxInstances = maxInstances;
            _pool = new ArrayList();
            _semaphore = new Semaphore(0, _maxInstances);
        }
        
        public T GetObject()
        {
            lock (_pool)
            {
                T thisObject = RemoveObject();
                if (thisObject is not null)
                {
                    return thisObject;
                }
                if (InstanceCount < MaxInstances)
                {
                    return CreateObject();
                }

                return null;
            }
        }

        public T WaitForObject()
        {
            lock (_pool)
            {
                T thisObject = RemoveObject();
                if (thisObject is not null)
                {
                    return thisObject;
                }
                if (InstanceCount < MaxInstances)
                {
                    return CreateObject();
                }
            }
            
            _semaphore.WaitOne();
            return WaitForObject();
        }

        public void Release(T obj)
        {
            if (obj is null)
            {
                throw new NullReferenceException("Object is null!!!");
            }

            lock (_pool)
            {
                var refThis = new WeakReference(obj);
                _pool.Add(refThis);
                _semaphore.Release();
            }
        }
        
        private T RemoveObject()
        {
            while (_pool.Count > 0)
            {
                var refThis = (WeakReference) _pool[_pool.Count - 1];
                _pool.RemoveAt(_pool.Count - 1);

                var thisObject = (T) refThis.Target;
                if (thisObject is not null)
                {
                    return thisObject;
                }

                _instanceCount--;
            }

            return null;
        }
        
        private T CreateObject()
        {
            T newObject = _creator.Create();
            _instanceCount++;
            return newObject;
        }
    }
}