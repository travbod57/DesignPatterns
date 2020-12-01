using System;

namespace Singleton.Singleton
{
    /*
     * Only really need it lazy if there are called to other external data sources
     * 
     * Is the singleton referenced in a tight loop with expensive locking?
     *      
     * SOURCE: https://csharpindepth.com/articles/singleton
     */

    public sealed class LazyThreadSafeWithoutLocksSingleton
    {
        private static readonly Lazy<LazyThreadSafeWithoutLocksSingleton> lazy = new Lazy<LazyThreadSafeWithoutLocksSingleton> (() => new LazyThreadSafeWithoutLocksSingleton());

        public static LazyThreadSafeWithoutLocksSingleton Instance { get { return lazy.Value; } }

        private LazyThreadSafeWithoutLocksSingleton()
        {
        }

        public string PersonName { get; set; }
    }
}