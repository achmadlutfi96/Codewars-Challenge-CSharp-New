using System;
using System.Collections.Generic;

public static class Kata
{
    public static string LastSurvivor(string letters, int[] coords)
    {
        if (letters.Length < 2)
        {
            return letters;
        }
        List<char> res = new List<char>(letters);
        foreach (int index in coords)
        {
            res.RemoveAt(index);
        }
        return string.Concat(res);

        // Alternative 1
        // foreach (var index in coords)
        //     letters = letters.Remove(index,1);
        // return letters;

        // Alternative 2
        // return coords.Aggregate(letters, (currLetter, el) => currLetter.Remove(el, 1));
    }

    public static void Main()
    {
        Console.WriteLine(LastSurvivor("abc", new int[] { 1, 1 }));
    }
}