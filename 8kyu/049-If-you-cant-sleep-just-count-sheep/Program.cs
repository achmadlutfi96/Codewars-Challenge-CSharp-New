// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public static class Kata
{
    public static string CountSheep(int n)
    {
        // throw new NotImplementedException();
        string res = "";
        for (int i = 1; i <= n; i++)
        {
            res = $"{res}{i} sheep...";
        }
        return res;
        // Alternative
        // return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
    }
    public static void Main()
    {
        Console.WriteLine(CountSheep(1));
        Console.WriteLine(CountSheep(5));
    }
}
