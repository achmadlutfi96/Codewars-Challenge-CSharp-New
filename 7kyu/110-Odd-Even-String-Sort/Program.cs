using System;
using System.Linq;

public class Kata
{
    public static string SortMyString(string s)
    {
        // your code here
        return $"{string.Concat(s.Where((v,i)=>i%2==0))} {string.Concat(s.Where((v,i)=>i%2==1))}";
    }

    static void Main()
    {
        Console.WriteLine(SortMyString("CodeWars"));
    }
}