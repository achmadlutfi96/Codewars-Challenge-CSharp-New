// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
using System;
public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        return beast.First() == dish.First() && beast.Last() == dish.Last();
    }
    public static void Main(){
        Console.WriteLine(Feast("great blue heron", "garlic naan"));
        Console.WriteLine(Feast("brown bear", "bear claw"));
    }
}
