// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum +=(int) MathF.Pow(number, 2);
        }
        return sum;

        // alternative
        // return numbers.Sum(n => n * n);
    }
}

public static class Program
{
    public static void Main(){
        Console.WriteLine(Kata.SquareSum(new int[] {1,2,2}));
    }
}