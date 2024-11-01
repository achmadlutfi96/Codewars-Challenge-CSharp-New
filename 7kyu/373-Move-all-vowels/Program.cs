using System;
using System.Linq;

public static class Kata
{
    public static string MoveVowel(string input)
    {
        // throw new NotImplementedError();
        return string.Concat(input.Where(x=>!"aeiou".Contains(x)))+string.Concat(input.Where(x=>"aeiou".Contains(x)));

        // Alternative 
        // return string.Concat(input.OrderBy(x => "aeiou".Contains(x)));
    }

    public static void Main()
    {
        Console.WriteLine(MoveVowel("maker"));
    }
}