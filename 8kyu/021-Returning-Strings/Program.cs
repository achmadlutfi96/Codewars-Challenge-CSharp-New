// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public static class Kata
{
    public static string Greet(string name)
    {
        // throw new NotImplementedException("Greet is not implemented.");
        return $"Hello, {name} how are you doing today?";
    }
    public static void Main()
    {
        Console.WriteLine(Greet("Ryan"));
    }
}
