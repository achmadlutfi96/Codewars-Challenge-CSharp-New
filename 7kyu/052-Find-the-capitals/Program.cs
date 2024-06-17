using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public static class Kata
{
    public static int[] Capitals(string word)
    {
        //Write your code here
        List<int> res = new List<int>();
        for (int i = 0; i < word.Length; i++)
        {
            if (Regex.IsMatch(word[i].ToString(), @"[A-Z]"))
            {
                res.Add(i);
            }
        }
        return res.ToArray();

        // Alternative 1
        //     var capitalIndexes = new List<int>();
        //   for (var i = 0; i < word.Length; i++)
        //   {
        //     if (char.IsUpper(word[i]))
        //       capitalIndexes.Add(i);
        //   }
        //   return capitalIndexes.ToArray();

        // Alternative 2
        // return Regex.Matches(word, "[A-Z]").Select(m => m.Index).ToArray();
    }

    public static void Main()
    {
        foreach (var item in Capitals("CodEWaRs"))
        {
            Console.WriteLine(item);
        }

    }
}