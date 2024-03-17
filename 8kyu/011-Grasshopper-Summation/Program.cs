// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public static class Kata
{
    public static int summation(int num)
    {
        //Code here
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum+=i;
        }
        return sum;

        // Alternative 1
        // return Enumerable.Range(1, num).Sum();
        // Alternative 2
        // return num*(num+1)/2;
    }

    public static void Main()
    {
        Console.WriteLine(summation(8));
    }
}
