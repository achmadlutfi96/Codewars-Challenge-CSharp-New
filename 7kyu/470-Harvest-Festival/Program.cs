using System;
using System.Linq;

static class Kata
{
    public static string Plant(char seed, int water, int fert, int temp)
    {
        return temp >= 20 && temp <= 30 ? string.Concat(Enumerable.Repeat(string.Concat(Enumerable.Repeat('-',water))+string.Concat(Enumerable.Repeat(seed, fert)),water)) : string.Concat(Enumerable.Repeat('-',water*water))+seed;
    }

    public static void Main()
    {
        Console.WriteLine(Plant('@', 4, 3, 23));
    }
}