// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;

public class Kata
{
    public static string ReverseWords(string str)
    {
        return string.Join(' ',str.Split(' ').Reverse());
    }
    public static void Main()
    {
        Console.WriteLine(ReverseWords("hello world!"));
    }
}
