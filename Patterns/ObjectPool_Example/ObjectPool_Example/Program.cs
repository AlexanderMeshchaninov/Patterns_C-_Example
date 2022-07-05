using System;
using System.Reflection;
using System.Threading;
using ObjectPool_Example.Realization;

namespace ObjectPool_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodInfo.GetCurrentMethod().Name);
            var reusablePool = new ReusablePool();
            
            var thrd1 = new Thread(Run);
            var thrd2 = new Thread(Run);
            var thisObject1 = reusablePool.GetObject();
            var thisObject2 = reusablePool.GetObject();
            thrd1.Start(reusablePool);
            thrd2.Start(reusablePool);
            ViewObject(thisObject1);
            ViewObject(thisObject2);
            Thread.Sleep(2000);
            reusablePool.Release(thisObject1);
            Thread.Sleep(2000);
            reusablePool.Release(thisObject2);

            Console.ReadKey();
        }

        public static void Run(Object obj)
        {
            Console.WriteLine("\t" + MethodInfo.GetCurrentMethod().Name);
            var reusablePool = (ReusablePool)obj;
            Console.WriteLine("\tstart wait");
            var thisObject1 = reusablePool.WaitForObject();
            ViewObject(thisObject1);
            Console.WriteLine("\tend wait");
            reusablePool.Release(thisObject1);
        }
        private static void ViewObject(Reusable thisObject)
        {
            foreach (var obj in thisObject.Objects)
            {
                Console.Write(obj + @" ");
            }
            
            Console.WriteLine();
        }
    }
}