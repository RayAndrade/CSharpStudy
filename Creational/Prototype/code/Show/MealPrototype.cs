namespace MealProtoType;

public class MealPrototype: Prototype
{
    public string Name { get; set; }
    public string Ingredients { get; set; }
    
    public MealPrototype(string name, string ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }
    
    public override Prototype Clone()
    {
        Console.WriteLine($"Cloning meal: {Name}... It might complain about identity theft.");
        return (Prototype)this.MemberwiseClone();
    }
    
    public override string ToString()
    {
        return $"Meal: {Name}, Ingredients: {Ingredients}";
    }
}