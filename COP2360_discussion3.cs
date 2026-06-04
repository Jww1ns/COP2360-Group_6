using system;


enum preferred_food
{
    Carrots,
    Lettuce,
    Dandelions

}

class Bunny
{
    public string Name;
    public int Age = 5;
    public readonly int Legs = 4;
    public preferred_food food;

}

class Program
{
    static void Main()
    {
        Bunny myBunny = new Bunny("Hops", preferred_food.Carrots);

        Console.WriteLine("Bunny name: " + myBunny.Name);
        Console.WriteLine("Age: " + myBunny.Age);
        Console.writeLine("Legs: " + myBunny.Legs);
        Console.WriteLine("Food: " + myBunny.food);
    }
}