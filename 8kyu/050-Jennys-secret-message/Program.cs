// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public static class Kata
{
    public static string greet(string name)
    {
        
        if (name == "Johnny") return "Hello, my love!";
        return "Hello, " + name + "!";
    }
    public static void Main()
    {
        Console.WriteLine(greet("Jim"));
        Console.WriteLine(greet("Johnny"));
    }
}
