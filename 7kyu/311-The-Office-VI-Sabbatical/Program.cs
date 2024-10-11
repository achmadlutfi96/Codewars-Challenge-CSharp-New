using System;
using System.Linq;

public class Kata
{
    public static string Sabb(string s, int val, int happiness)
    {
        return s.Count(x=>"sabbatical".Contains(char.ToLower(x)))+val+happiness > 22 ? "Sabbatical! Boom!" : "Back to your desk, boy.";
    }

    public static void Main()
    {
        Console.WriteLine(Sabb("Can I have a sabbatical?", 5, 5));
        Console.WriteLine(Sabb("Why are you shouting?", 7, 2));
        Console.WriteLine(Sabb("What do you mean I cant learn to code??", 8, 9));
        Console.WriteLine(Sabb("Please calm down", 9, 1));
    }
}
