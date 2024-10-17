using System;

public static class Kata
{
    public static string SortVowels(string s)
    {
        if (s == null)
        {
            return "";
        }
        return string.Join("\n", s.Select(x => "aiueo".Contains(char.ToLower(x)) ? $"|{x}" : $"{x}|"));

        // Alternative 
        // return string.IsNullOrEmpty(s)
        // ? ""
        // : string.Join("\n", s.Select(c => "aeiouAEIOU".Contains(c) ? $"|{c}" : $"{c}|"));
    }

    public static void Main()
    {
        Console.WriteLine(SortVowels("Codewars"));
        Console.WriteLine(SortVowels("Rnd Te5T"));
    }
}