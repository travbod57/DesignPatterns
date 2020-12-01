namespace Singleton.Singleton
{
    /*
     * 1) This implementation is thread-safe.
     * 2) In the following code, the thread is locked on a shared object and checks whether an instance has been created or not.
     * 3) This takes care of the memory barrier issue and ensures that only one thread will create an instance.
     * 4) For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate to false.
     * 5) The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.
     * 
     * Is the singleton referenced in a tight loop with expensive locking?
     * 
     * SOURCE: https://csharpindepth.com/articles/singleton
     */

    public sealed class ThreadSafeSingleton
    {
        private static readonly object padlock = new object();
        private static ThreadSafeSingleton instance = null;

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }

                    return instance;
                }
            }
        }

        public string PersonName { get; set; }
    }
}