using System;
using System.Linq;

public static class Kata
{
    public static int[] Take(int[] arr, int n)
    {
        return arr.Take(n).ToArray();
    }

    public static void Main(){
        foreach (var item in Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3))
        {
            Console.WriteLine(item);
        }

        foreach (var item in Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 0))
        {
            Console.WriteLine(item);
        }

        foreach (var item in Take(new int[] { }, 3))
        {
            Console.WriteLine(item);
        }
    }
}