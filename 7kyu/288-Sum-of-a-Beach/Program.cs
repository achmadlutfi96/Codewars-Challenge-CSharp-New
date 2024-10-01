using System.Text.RegularExpressions;

public class Kata
{
    public static int SumOfABeach(string s)
    {
        // your code
        return Regex.Matches(s.ToLower(), @"(sand)|(water)|(sun)|(fish)").Count();
    }

    public static void Main()
    {
        Console.WriteLine(SumOfABeach("sunsunsunsun"));
    }
}