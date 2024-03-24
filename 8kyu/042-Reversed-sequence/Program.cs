// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static int[] ReverseSeq(int n)
    {
        // throw new NotImplementedException();
        List<int> res = new List<int>();
        for (int i = n; i > 0; i--)
        {
            res.Add(i);
        }
        return res.ToArray();

        // Alternative
        // return Enumerable.Range(1, n).Reverse().ToArray();
    }
    public static void Main()
    {
        foreach (var item in ReverseSeq(5))
        {
            Console.WriteLine(item);
        }
    }
}
