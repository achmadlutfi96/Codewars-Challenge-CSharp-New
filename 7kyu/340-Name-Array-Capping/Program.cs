using System;
using System.Linq;

public static class Kata
{
    public static string[] CapMe(string[] strings)
    {
       return strings.Select(s=>char.ToUpper(s[0])+s.Substring(1).ToLower()).ToArray(); 
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", CapMe(new string[] {"KARLY", "DANIEL", "KELSEY"})));
    }
}