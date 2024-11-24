using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
    {
        var results = new List<string>
        {
            chromosome1.Substring(0, cut) + chromosome2.Substring(cut),
            chromosome2.Substring(0, cut) + chromosome1.Substring(cut)
        };
        return results;

        // Alternative
        // return new[] {chromosome1[..cut] + chromosome2[cut..], chromosome2[..cut] + chromosome1[cut..]};
    }


    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Crossover("110", "001", 2)));
        Console.WriteLine(string.Join(", ", Crossover("111000", "000110", 3)));
    }
}