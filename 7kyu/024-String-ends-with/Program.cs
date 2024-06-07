using System;
public class Kata
{
    public static bool Solution(string str, string ending)
    {
        // TODO: complete
        return str.EndsWith(ending);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Solution("!@#$%^&*() :-)", ":-)"));
        Console.WriteLine(Solution("samurai", "ai"));
    }
}