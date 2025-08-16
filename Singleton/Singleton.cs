namespace DesignPatterns.Singleton
{
    /// <summary>
    /// The Singleton class ensures that only one instance of the class is created and provides a global point of access to that instance.
    /// Key Points:
    /// - Private constructor to prevent instantiation from outside this class.
    /// - A static field to store the single instance.
    /// - Thread-safety ensured using 'lock' (double-checked locking).
    /// - Lazy initialization: instance is created only when first accessed.
    /// </summary>
    internal class Singleton
    {
        private Singleton() { }

        // Holds the single instance of the Singleton class.
        // Initially null until the first request.
        private static Singleton _instance;

        // An object used to lock the critical section to ensure thread-safety during instance creation.
        private static object _locker = new object();

        // Gets the single instance of the Singleton class.
        // Uses double-checked locking to ensure only one instance is created, even in multi-threaded environments.
        public static Singleton GetInstance()
        {
            // First check without locking for performance.
            if (_instance == null)
            {
                lock (_locker) // Lock to ensure only one thread can create the instance.
                {
                    // Second check inside lock to ensure instance wasn't created by another thread.
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
            return _instance;
        }
    }
}