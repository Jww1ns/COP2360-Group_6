using System;
using System.Runtime.InteropServices;

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
    public preferred_food Food;

    public Bunny(string name, int age, preferred_food food)
    {
        Name = name;
        Age = age;
        Food = food;
    }

}

class Program
{
    static void Main()
    {
        Bunny myBunny = new Bunny("Hops", 4, preferred_food.Carrots);

        Console.WriteLine("Bunny name: " + myBunny.Name);
        Console.WriteLine("Age: " + myBunny.Age);
        Console.WriteLine("Legs: " + myBunny.Legs);
        Console.WriteLine("Food: " + myBunny.Food);
    }
}