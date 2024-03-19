// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        //Code goes here!
        return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
    }
    public static void Main()
    {
        Console.WriteLine(FindNeedle(new object[]{'3', "123124234", null, "needle", "world", "hay", 2, '3', true, false}));
    }
}
