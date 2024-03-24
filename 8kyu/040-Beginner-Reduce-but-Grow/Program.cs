// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
public class Kata
{
    public static int Grow(int[] x)
    {
        int res = 1;
        foreach (var i in x)
        {
            res*=i;
        }
        return res;

        // Alternative
        // return x.Aggregate((p, next) => p * next);
    }
    public static void Main()
    {
        Console.WriteLine(Grow(new[] { 1, 2, 3 }));
    }
}
