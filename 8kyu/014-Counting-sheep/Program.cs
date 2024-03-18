// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        //TODO
        return sheeps.Where(i => i == true).Count();

        // Alternative 1
        // return sheeps.Count(s => s);

        // Alternative Traditional / Manual
        // int count = 0;
        // foreach (bool sheep in sheeps)
        // {
        //     if (sheep) count++;
        // }
        // return count;
    }
    public static void Main()
    {
        Console.WriteLine(CountSheeps(new bool[] { true, false, true }));
    }
}
