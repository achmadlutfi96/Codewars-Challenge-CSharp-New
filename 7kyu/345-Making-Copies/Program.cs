using System;
using System.Collections.Generic;
using System.Linq;

public static class ListExtensions
{
    public static List<T> Copy<T>(this List<T> lst)
    {
        return lst.Take(lst.Count).ToList();

        // Alternative
        // return new List<T>(lst);
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", Copy<int>(new List<int> {1, 2, 3, 4})));
    }
}