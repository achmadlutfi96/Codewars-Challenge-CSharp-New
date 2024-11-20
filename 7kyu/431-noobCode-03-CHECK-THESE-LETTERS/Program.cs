using System;
using System.Linq;

public class Kata
{
    public static bool LetterCheck(string[] arr)
    {
        return arr[1].ToLower().Distinct().Select(x=> arr[0].ToLower().Contains(x)).All(x=>x==true);

        // Alternative 1
        // return arr[1].ToUpper().All(arr[0].ToUpper().Contains);

        // Alternative 2
        // return !arr[1].ToUpper().Except(arr[0].ToUpper()).Any();
    }

    public static void Main()
    {
        Console.WriteLine(LetterCheck(new string[] { "trances", "nectar" }));
        Console.WriteLine(LetterCheck(new string[] { "assert", "staring" }));
    }
}