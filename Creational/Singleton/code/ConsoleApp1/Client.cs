namespace GangOfFourPatterns.Singleton;

public class Client
{
    public static void Main(string[] args)
    {
        // Accessing Singleton instance
        Singleton instance1 = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();

        // Perform operations
        instance1.Operation();
        instance2.Operation();

        // Check if both instances are the same
        Console.WriteLine($"Are both instances equal? {ReferenceEquals(instance1, instance2)}");
    }
}
