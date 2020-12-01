using Singleton.Singleton;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonCallOne = ThreadSafeSingleton.Instance;
            var singletonCallTwo = ThreadSafeSingleton.Instance;

            Console.WriteLine($"ThreadSafeSingletons equality: { singletonCallOne.Equals(singletonCallTwo) }");

            var singletonCallThree = ThreadSafeWithoutLocksSingleton.Instance;
            var singletonCallFour = ThreadSafeWithoutLocksSingleton.Instance;

            Console.WriteLine($"ThreadSafeWithoutLocksSingletons equality: { singletonCallThree.Equals(singletonCallFour) }");

            var singletonCallFive = LazyThreadSafeWithoutLocksSingleton.Instance;
            var singletonCallSix = LazyThreadSafeWithoutLocksSingleton.Instance;

            Console.WriteLine($"LazyThreadSafeWithoutLocksSingleton equality: { singletonCallFive.Equals(singletonCallSix) }");

            Console.ReadLine();
        }
    }
}
