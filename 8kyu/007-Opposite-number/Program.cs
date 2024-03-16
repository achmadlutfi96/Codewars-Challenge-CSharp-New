// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
    public static int Opposite(int number)
    {
        // Happy Coding
        return -number;
    }
}

// Console.WriteLine(Kata.Opposite(6));

public class Program
{
    public static void Main(){
        Console.WriteLine(Kata.Opposite(6));
        Console.WriteLine(Kata.Opposite(-6));
    }
}
