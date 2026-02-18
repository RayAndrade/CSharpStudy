namespace Show;

public class Client
{
    public static void ClientCode(AbstractHandler handler)
    {
        foreach (var food in new List<string> { "Bone", "Catnip", "Cheese" })
        {
            Console.WriteLine($"Client: Who wants a {food}?");
            var result = handler.Handle(food);
            if (result != null)
            {
                Console.Write($"   {result}");
            }
            else
            {
                Console.WriteLine($"   {food} was left untouched.");
            }
        }
    }
}