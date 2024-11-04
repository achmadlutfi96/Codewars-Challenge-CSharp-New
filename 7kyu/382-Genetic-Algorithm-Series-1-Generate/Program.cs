using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Generate(int length)
    {
        Random rn = new Random();
        return string.Concat(Enumerable.Range(0, length).Select(x=>rn.Next(0,2).ToString()));
    }

    public static void Main()
    {
        Console.WriteLine(Generate(16));
    }
}