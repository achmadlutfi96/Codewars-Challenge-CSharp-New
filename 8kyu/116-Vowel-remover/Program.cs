using System;
using System.Linq;

public class Kata
{
    public static string Shortcut(string input)
    {
        // TODO: Remove vowels
        char[] v = {'a', 'e', 'i', 'o', 'u' };
        return String.Concat(input.Where(c => !v.Contains(c)));

        // ALTERNATIVE
        // return String.Concat(input.Where(c => !"aeiou".Contains(c)));
    }
    public static void Main(){
        Console.WriteLine(Shortcut("hello"));
        Console.WriteLine(Shortcut("codewars"));
        Console.WriteLine(Shortcut("HELLO"));
    }
}