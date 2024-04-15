using System;
using System.Linq;

public static class Kata
{
    public static string MultiTable(int number)
    {
        return String.Join("\n",Enumerable.Range(1, 10).Select(i => $"{i} * {number} = {i*number}"));
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(MultiTable(5));
    }
}