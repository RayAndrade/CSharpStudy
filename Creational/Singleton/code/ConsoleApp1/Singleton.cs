namespace GangOfFourPatterns.Singleton;

public sealed class Singleton
{
    // Static field to hold the single instance of the Singleton
    private static Singleton _uniqueInstance;

    // Lock object for thread-safety
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created");
    }

    // Public static method to provide global access to the Singleton instance
    public static Singleton GetInstance()
    {
        // Double-checked locking to ensure thread-safety and lazy initialization
        if (_uniqueInstance == null)
        {
            lock (_lock)
            {
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new Singleton();
                }
            }
        }
        return _uniqueInstance;
    }

    // Method representing a behavior of the Singleton
    public void Operation()
    {
        Console.WriteLine("Singleton Operation Executed");
    }  
}