// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
public class Kata
{
    public static double SumArray(double[] array)
    {
        return array.Sum();
    }
    public static void Main()
    {
        Console.WriteLine(SumArray(new double[] {1, 5.2, 4, 0, -1}));
    }
}
