using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Mutate(string chromosome, double probability)
    {
        Random random = new Random();
        return String.Join("", chromosome.Select(c => random.NextDouble() <= probability ? (c == '0' ? "1" : "0") : c.ToString()));
    }

    public static void Main()
    {
        Console.WriteLine(Mutate("1111", 1));
    }
}