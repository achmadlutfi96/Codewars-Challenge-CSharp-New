// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class DivisibleNb
{
    public static bool IsDivisible(int n, int x, int y)
    {
        // your code
        return n%x==0 && n%y==0;
    }

    public static void Main(){
        Console.WriteLine(IsDivisible(12, 4, 3));
    }
}

