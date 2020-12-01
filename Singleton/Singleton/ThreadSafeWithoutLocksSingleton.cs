using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Singleton
{
    /*
     * As you can see, this is really is extremely simple - but why is it thread-safe and how lazy is it? Well, static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain. 
     * Given that this check for the type being newly constructed needs to be executed whatever else happens, it will be faster than adding extra checking as in the previous examples.  
     * 
     * SOURCE: https://csharpindepth.com/articles/singleton
     * 
     */

    public sealed class ThreadSafeWithoutLocksSingleton
    {
        private static readonly ThreadSafeWithoutLocksSingleton instance = new ThreadSafeWithoutLocksSingleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static ThreadSafeWithoutLocksSingleton()
        {
        }

        private ThreadSafeWithoutLocksSingleton()
        {
        }

        public static ThreadSafeWithoutLocksSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public string PersonName { get; set; }
    }
}
