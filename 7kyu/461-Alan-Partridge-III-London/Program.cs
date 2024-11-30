using System;
using System.Linq;
public class Kata
{
    public static string Alan(string[] x)
    {
        string[] str = new string[] {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"};
        return str.All(y=> x.Contains(y)) ? "Smell my cheese you mother!": "No, seriously, run. You will miss it.";

        // Alternative
        // return Array.TrueForAll(new string[] {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"}, v => x.Any(i => i == v)) ? "Smell my cheese you mother!" : "No, seriously, run. You will miss it.";
    }

    public static void Main()
    {
        Console.WriteLine(Alan(new string[] {"Norwich", "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway", "London"}));
        Console.WriteLine(Alan(new string[] {"London", "Norwich"}));
    }
}